using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sphero_Learning.Blocks;
using Sphero_Learning.Blocks.Conditionals;
using Sphero_Learning.Blocks.Actions;
using InTheHand.Net.Sockets;
using Sphero;
using System.ComponentModel;
using System.Threading;
using System.Text;
using Sphero_Learning.Forms;
using InTheHand.Net.Bluetooth;

namespace Sphero_Learning
{
    public partial class m_MainForm : MetroFramework.Forms.MetroForm
    {
        #region Fields

        //Variáveis globais

        private List<Block> m_Blocks = new List<Block>();
        private BluetoothClient m_BluetoothClient;
        private SpheroConnector m_SpheroConnector = new SpheroConnector();
        private BackgroundWorker m_SearchSpheroWorker = new BackgroundWorker();
        private BackgroundWorker m_ComandsWorker = new BackgroundWorker();

        #endregion

        #region Delegates

        delegate void SetStatusTextCallback(string p_Text);
        delegate void PrintToLog(string p_Text);

        #endregion

        #region Constructor

        //Inicializa os controles do formulário e atribui tela cheia
        public m_MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Events

        //Evento de carregamento do formulário
        private void m_MainForm_Load(object sender, EventArgs e)
        {
            //Verificação do adaptador bluetooth
            if(isBluetoothAdapterEnabled())
            {
                m_BluetoothClient = new BluetoothClient();

                loadTreeViewImages();

                fillLists();

                loadSpheroProperties();

                //Preparar uma thread separada "BackgroundWorker" para executar os blocos
                m_ComandsWorker.DoWork += CommandsWorker_DoWork;
                m_ComandsWorker.RunWorkerCompleted += CommandsWorker_RunWorkerCompleted;

                //Preparar uma thread separada "BackgroundWorker" para procurar e conectar com o sphero
                m_SearchSpheroWorker.DoWork += SearchSpheroWorker_DoWork;
                m_SearchSpheroWorker.RunWorkerCompleted += SearchSpheroWorker_RunWorkerCompleted;
                m_SearchSpheroWorker.RunWorkerAsync();

                //Mudar os status
                m_LblSpheroStatus.Text = m_LblSpheroStatus.Text + " Procurando...";
                printToLog("Procurando Sphero...");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Adaptador bluetooth desligado, por favor habilite o adaptador e rode o programa novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //Evento de click do botão de criar variáveis
        private void m_BtnCreateVar_Click(object sender, EventArgs e)
        {
            CreateVariableForm v_Form = new CreateVariableForm();

            v_Form.ShowDialog();

            if (v_Form.NewProperty != null)
            {
                Globals.m_Properties.Add(v_Form.NewProperty);
                m_TvBlocks.Nodes[3].Nodes.Add(v_Form.NewProperty.Name, v_Form.NewProperty.propertyToString());

                printToLog(String.Format("Criada variável {0}", v_Form.NewProperty.propertyToString()));
            }
        }

        //Evento de click do botão de remover variáveis
        private void m_BtnRemoveVar_Click(object sender, EventArgs e)
        {
            if(m_TvBlocks.SelectedNode.Parent == m_TvBlocks.Nodes[3])
            {
                Property v_RemovedProperty = Globals.m_Properties.Find(i => i.Name == m_TvBlocks.SelectedNode.Name);

                printToLog(String.Format("Removida variável {0}", v_RemovedProperty.propertyToString()));

                Globals.m_Properties.Remove(v_RemovedProperty);

                m_TvBlocks.Nodes.Remove(m_TvBlocks.SelectedNode);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecione uma variável.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Blocks

        //Eventos relacionados ao Drag and Drop dos blocos do treeview

        private void m_TvBlocks_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void m_TvBlocks_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void m_TvBlocks_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void m_MainPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void m_MainPanel_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode v_DroppedItem = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            if (v_DroppedItem.Parent != m_TvBlocks.Nodes[0] && v_DroppedItem.Parent != m_TvBlocks.Nodes[1])
            {
                return;
            }

            Block v_NewBlock = null;

            //TODO: substituir por uma classe com Nome/Tipo...
            switch (v_DroppedItem.Text)
            {
                case "Se":
                    {
                        v_NewBlock = new IfBlock();
                    }
                    break;

                case "Mover":
                    {
                        v_NewBlock = new MoveBlock();
                    }
                    break;

                case "Virar":
                    {
                        v_NewBlock = new TurnBlock();
                    }
                    break;

                case "MudarCor":
                    {
                        v_NewBlock = new ColorBlock();
                    }
                    break;

                default:
                    {

                    }
                    break;
            }

            v_NewBlock.Position = new Point(e.X - m_MainPanel.Location.X, e.Y - m_MainPanel.Location.Y);

            if (v_NewBlock != null && v_NewBlock.Valid)
            {
                if(m_Blocks.Count > 0)
                {
                    if(m_Blocks[m_Blocks.Count-1].Type == BlockType.Conditional)
                    {
                        if (m_Blocks[m_Blocks.Count - 1].GetType() == typeof(IfBlock))
                        {
                            IfBlock v_IfBlock = m_Blocks[m_Blocks.Count - 1] as IfBlock;

                            v_IfBlock.GotoBlock = v_NewBlock;
                        }
                        else if (m_Blocks[m_Blocks.Count - 1].GetType() == typeof(WhileBlock))
                        {

                        }
                        else if (m_Blocks[m_Blocks.Count - 1].GetType() == typeof(ForBlock))
                        {

                        }
                    }
                }

                m_Blocks.Add(v_NewBlock);

                m_MainPanel.Invalidate();

                printToLog(String.Format("Adicionado bloco <{0}> em (X: {1} Y: {2})", v_NewBlock.Text, e.X, e.Y));
            }
        }

        //Evento de renderização do controle relacionado por abrigar os blocos
        private void m_MainPanel_CustomPaint(object sender, MetroFramework.Drawing.MetroPaintEventArgs e)
        {
            Pen v_DashedPen = new Pen(Color.Black, 2.0f);

            v_DashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            for (int i_Block = 0; i_Block < m_Blocks.Count; i_Block++)
            {
                m_Blocks[i_Block].draw(e.Graphics);

                if (m_Blocks.Count > 1 && i_Block < m_Blocks.Count - 1)
                {
                    e.Graphics.DrawLine(v_DashedPen, m_Blocks[i_Block].Position, m_Blocks[i_Block + 1].Position);
                }
            }
        }

        //Evento de click do botão de remover o último bloco adicionado
        private void m_BtnRemoveLastBlock_Click(object sender, EventArgs e)
        {
            if (m_Blocks.Count > 0)
            {
                printToLog(String.Format("Removido bloco <{0}> em (X: {1} Y: {2})", m_Blocks[m_Blocks.Count - 1].Text, m_Blocks[m_Blocks.Count - 1].Position.X, m_Blocks[m_Blocks.Count - 1].Position.Y));

                m_Blocks.RemoveAt(m_Blocks.Count - 1);

                m_MainPanel.Invalidate();
            }
        }

        #endregion

        #region Sphero

        //evento chamado no fim da execução da thread separada
        private void SearchSpheroWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //checar se a variável local foi preenchida se não tentar denovo...
            if (m_SpheroConnector.Sphero == null)
            {
                Thread.Sleep(1000);

                m_SearchSpheroWorker.RunWorkerAsync();
            }
            else
            {
                setStatusText("Sphero: Conectado!");

                printToLog("Sphero Connectado!");

                //criar um "listener" para o recebimento de pacotes do sphero
                m_SpheroConnector.Sphero.Listener.PacketReceived += Listener_PacketReceived;
                m_SpheroConnector.Sphero.PacketSent += Sphero_PacketSent;
                m_BtnSleep.Enabled = true;

                Thread.Sleep(3000);

                m_SpheroConnector.Sphero.SendPacket(new SpheroCommandPacket(CoreCommand.CMD_GET_BT_NAME, (byte)CoreCommand.CMD_GET_BT_NAME, 0x00));
                m_SpheroConnector.Sphero.SendPacket(new SpheroCommandPacket(SpheroCommand.CMD_SET_CAL, CommandSequencer.Next, 0x00));
            }
        }

        //Evento de callback do envio dos pacotes ao sphero
        private void Sphero_PacketSent(PacketSentEventArgs e)
        {
            SpheroCommandPacket v_PacketSent = e.Packet as SpheroCommandPacket;

            printToLog("Enviado commando: " + v_PacketSent.FullName);
        }

        //evento chamado na execução da thread separada
        private void SearchSpheroWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //checar se a variável local Sphero já está preenchida
            if (m_SpheroConnector.Sphero == null)
            {
                //enumerar todos os dispositivos bluetooth e retornar o sphero entre eles
                m_SpheroConnector.Find();

                //caso o sphero tenha sido encontrado
                if (m_SpheroConnector.DeviceFound)
                {
                    setStatusText("Sphero: Conectando...");
                    printToLog("Conectando com o Sphero...");

                    //tentar conectar com o sphero por até 5 vezes antes de desistir
                    m_SpheroConnector.Connect(5);
                }
            }
        }

        //listener de recebimento de pacotes do sphero
        private void Listener_PacketReceived(PacketReceivedEventArgs e)
        {
            if (e.Packet is SpheroResponsePacket)
            {
                SpheroResponsePacket v_SpheroRespopse = e.Packet as SpheroResponsePacket;

                if (v_SpheroRespopse.ResponseCode != ResponseCode.CommandOK)
                {
                    return;
                }

                switch (v_SpheroRespopse.SequenceNumber)
                {
                    case (byte)CoreCommand.CMD_GET_BT_NAME:
                        {
                            byte[] v_ASCII_Name = new byte[16];
                            byte[] v_ASCII_BTA = new byte[12];

                            Array.Copy(v_SpheroRespopse.Data, 5, v_ASCII_Name, 0, 16);
                            Array.Copy(v_SpheroRespopse.Data, 21, v_ASCII_BTA, 0, 12);

                            string v_BTName = Encoding.ASCII.GetString(v_ASCII_Name);
                            string v_BTAddress = Encoding.ASCII.GetString(v_ASCII_BTA);

                            printToLog("Sphero BT Name: " + v_BTName.Replace("\0", string.Empty));
                            printToLog("Sphero BT Address: " + v_BTAddress);
                        }
                        break;

                    case (byte)SpheroCommand.CMD_GET_RGB_LED:
                        {
                            byte[] v_RGBColor = new byte[3];

                            Array.Copy(v_SpheroRespopse.Data, 5, v_RGBColor, 0, 3);

                            Globals.m_Properties.Find(i_Property => i_Property.Name == "Cor.Vermelho").Value = (int)v_RGBColor[0];
                            Globals.m_Properties.Find(i_Property => i_Property.Name == "Cor.Verde").Value = (int)v_RGBColor[1];
                            Globals.m_Properties.Find(i_Property => i_Property.Name == "Cor.Azul").Value = (int)v_RGBColor[2];
                        }
                        break;
                }
            }
        }

        //evento de click para desligar o sphero
        private void m_BtnSleep_Click(object sender, EventArgs e)
        {
            //enviar o pacote com o comando para desligar ao sphero
            m_SpheroConnector.Sphero.SendPacket(new SpheroCommandPacket(CoreCommand.CMD_SLEEP, CommandSequencer.Next,  0x00, 0x00, 0x00, 0x00, 0x00 ));
            m_SpheroConnector.Close();

            m_BtnSleep.Enabled = false;

            m_LblSpheroStatus.Text = "Sphero: Procurando...";
            printToLog("Procurando Sphero...");
            //recomeçar a procura...
            m_SearchSpheroWorker.RunWorkerAsync();
        }

        #endregion

        #region Commands

        //Evento de callback da thread asincrona para execução dos blocos
        private void CommandsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i_Block = 0; i_Block < m_Blocks.Count; i_Block++)
            {
                m_Blocks[i_Block].BorderColor = new Pen(Color.Green, 1.0f);
                m_Blocks[i_Block].ForeColor = new SolidBrush(Color.Green);

                m_MainPanel.Invalidate();

                if (m_Blocks[i_Block].Type == BlockType.Action)
                {
                    m_SpheroConnector.Sphero.SendPacket(m_Blocks[i_Block].Command);
                }
                else if (m_Blocks[i_Block].Type == BlockType.Conditional)
                {
                    if (m_Blocks[i_Block].GetType() == typeof(IfBlock))
                    {
                        IfBlock v_IfBlock = m_Blocks[i_Block] as IfBlock;

                        if(v_IfBlock.Arugment1.SpheroCommand != null)
                        {
                            m_SpheroConnector.Sphero.SendPacket(v_IfBlock.Arugment1.SpheroCommand);
                        }

                        if (v_IfBlock.Arugment2.SpheroCommand != null)
                        {
                            m_SpheroConnector.Sphero.SendPacket(v_IfBlock.Arugment2.SpheroCommand);
                        }

                        if (v_IfBlock.evaluateExpression() == false)
                        {
                            e.Result = i_Block;

                            i_Block = m_Blocks.IndexOf(v_IfBlock.findLastChild(v_IfBlock));
                            continue;
                        }
                    }
                    else if (i_Block.GetType() == typeof(WhileBlock))
                    {

                    }
                    else if (i_Block.GetType() == typeof(ForBlock))
                    {

                    }
                }

                Thread.Sleep(1000);

                m_Blocks[i_Block].BorderColor = new Pen(Color.Black, 1.0f);
                m_Blocks[i_Block].ForeColor = new SolidBrush(Color.Black);

                m_MainPanel.Invalidate();

                e.Result = i_Block;
            }
        }

        //Evento de término da execução dos blocos
        private void CommandsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Comandos executados!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Thread.Sleep(1000);

            if (m_Blocks.Count > (int)e.Result)
            {
                m_Blocks[(int)e.Result].BorderColor = new Pen(Color.Black, 1.0f);
                m_Blocks[(int)e.Result].ForeColor = new SolidBrush(Color.Black);
            }

            m_MainPanel.Invalidate();
        }

        //Evento de click do botão de executar os blocos
        private void m_BtnRun_Click(object sender, EventArgs e)
        {
            if (m_SpheroConnector != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Começando a execuçãs dos comandos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                m_ComandsWorker.RunWorkerAsync();
            }
        }

        #endregion

        #endregion

        #region Methods

        //Método de chamada com sincronização de threads para alterar o texto da label de status
        private void setStatusText(string p_Text)
        {
            if (m_LblSpheroStatus.InvokeRequired)
            {
                SetStatusTextCallback v_Callback = new SetStatusTextCallback(setStatusText);
                this.Invoke(v_Callback, new object[] { p_Text });
            }
            else
            {
                m_LblSpheroStatus.Text = p_Text;
            }
        }

        //Método de chamada com sincronização de threads para imprimir no log
        private void printToLog(string p_Text)
        {
            if (m_TbxLog.InvokeRequired)
            {
                PrintToLog v_Callback = new PrintToLog(printToLog);
                this.Invoke(v_Callback, new object[] { p_Text });
            }
            else
            {
                m_TbxLog.Text += DateTime.Now.ToString("HH:mm:ss") + " - " + p_Text + Environment.NewLine;
                m_TbxLog.SelectionStart = m_TbxLog.Text.Length;
                m_TbxLog.ScrollToCaret();
            }
        }

        //Método para carregar o ícone de bloco utilizado no treeview
        private void loadTreeViewImages()
        {
            ImageList v_TreeViewImageList = new ImageList();

            v_TreeViewImageList.Images.Add("Childs", Properties.Resources.Cube);

            m_TvBlocks.ImageList = v_TreeViewImageList;
        }

        //Método para carregar as propriedades utilizadas pelo Sphero
        private void loadSpheroProperties()
        {
            Property v_NewSperoProperty = new Property("Cor.Vermelho", 0, PropertyType.Integer);

            v_NewSperoProperty.SpheroCommand = Globals.GET_RGB_LED;

            Globals.m_Properties.Add(v_NewSperoProperty);
            addTreeNode(2, "Cor.Vermelho", "Cor.Vermelho");

            v_NewSperoProperty = new Property("Cor.Verde", 0, PropertyType.Integer);

            v_NewSperoProperty.SpheroCommand = Globals.GET_RGB_LED;

            Globals.m_Properties.Add(v_NewSperoProperty);
            addTreeNode(2, "Cor.Verde", "Cor.Verde");

            v_NewSperoProperty = new Property("Cor.Azul", 0, PropertyType.Integer);

            v_NewSperoProperty.SpheroCommand = Globals.GET_RGB_LED;

            Globals.m_Properties.Add(v_NewSperoProperty);
            addTreeNode(2, "Cor.Azul", "Cor.Azul");
        }

        //Método facilitador para adicionar nodes ao treeview
        private void addTreeNode(int p_Parent, string p_Key, string p_Text)
        {
            if(p_Parent == -1)
            {
                m_TvBlocks.Nodes.Add(p_Key, p_Text);
            }
            else
            {
                m_TvBlocks.Nodes[p_Parent].Nodes.Add(p_Key, p_Text);
            }
        }

        //Método para preencher a lista de condições
        private void fillLists()
        {
            Globals.m_Conditions.Add(new Condition(">", 0));
            Globals.m_Conditions.Add(new Condition("<", 1));
            Globals.m_Conditions.Add(new Condition(">=", 2));
            Globals.m_Conditions.Add(new Condition("<=", 3));
            Globals.m_Conditions.Add(new Condition("==", 4));
            Globals.m_Conditions.Add(new Condition("!=", 5));
        }

        //Método para verificar se o adaptador bluetooth está disponível
        private bool isBluetoothAdapterEnabled()
        {
            BluetoothRadio v_RadioInstace = BluetoothRadio.PrimaryRadio;

            if (v_RadioInstace == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}
