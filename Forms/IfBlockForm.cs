using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sphero_Learning.Forms
{
    public partial class IfBlockForm : MetroFramework.Forms.MetroForm
    {
        #region Fields

        //Variáveis globais

        private Property m_Argument1;
        private Property m_Argument2;
        private Condition m_Condition;
        private bool m_Validated = false;

        #endregion

        #region Properties

        //Propriedades

        public Property Argument1
        {
            get { return m_Argument1; }

            set { m_Argument1 = value; }
        }

        public Condition Condition
        {
            get { return m_Condition; }

            set { m_Condition = value; }
        }

        public Property Argument2
        {
            get { return m_Argument2; }

            set { m_Argument2 = value; }
        }

        public bool Valid
        {
            get { return m_Validated; }

            set { m_Validated = value; }
        }

        #endregion

        #region Constructor

        public IfBlockForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        //Evento de carregamento do formulário
        private void IfBlockForm_Load(object sender, EventArgs e)
        {
            fillComboboxes();

            updatePreview();
        }

        //Evento de click do botão accept para criar um novo block if com os argumentos e condições especificados
        private void m_BtnAccept_Click(object sender, EventArgs e)
        {
            m_Validated = validateInput();

            if(m_Validated)
            {
                this.Close();
            }
        }

        //Evento de click do botão cancel para cancelar a criação do bloco
        private void m_BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento de mudança do index selecionado do combobox de argumento1
        private void m_CbxArgument1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Argument1 = (Property)m_CbxArgument1.SelectedItem;

            updatePreview();
        }

        //Evento de mudança do index selecionado do combobox da condição
        private void m_CbxCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Condition = (Condition)m_CbxCondition.SelectedItem;

            updatePreview();
        }

        //Evento de mudança do index selecionado do combobox de argumento2
        private void m_CbxArgument2_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Argument2 = (Property)m_CbxArgument2.SelectedItem;

            updatePreview();
        }

        #endregion

        #region Methods

        //Método responsável por preencher os comboboxes de argumentos e condição
        private void fillComboboxes()
        {
            m_CbxArgument1.DataSource = new BindingSource(Globals.m_Properties, null).DataSource;
            m_CbxArgument1.DisplayMember = "Name";
            m_CbxArgument1.ValueMember = "Value";

            m_CbxArgument2.BindingContext = new BindingContext();
            m_CbxArgument2.DataSource = new BindingSource(Globals.m_Properties, null).DataSource;
            m_CbxArgument2.DisplayMember = "Name";
            m_CbxArgument2.ValueMember = "Value";
          
            m_CbxCondition.DataSource = new BindingSource(Globals.m_Conditions, null).DataSource;
            m_CbxCondition.DisplayMember = "Description";
            m_CbxCondition.ValueMember = "Id";

            m_Argument1 = (Property)m_CbxArgument1.SelectedItem;
            m_Condition = (Condition)m_CbxCondition.SelectedItem;
            m_Argument2 = (Property)m_CbxArgument2.SelectedItem;
        }

        //Método para atualização do preview do bloco
        private void updatePreview()
        {
            if(m_Argument1 == null || m_Condition == null || m_Argument2 == null)
            {
                return;
            }

            m_LblPreview.Text = String.Format("Se {0} {1} {2}", m_Argument1.Name, m_Condition.Description, m_Argument2.Name);
        }
        
        //Método para validação do bloco if que checa quanto a equivalência de tipos de argumentos e quanto a exceção na comparação de booleans
        public bool validateInput()
        {
            if(m_Argument1.Type != m_Argument2.Type)
            {
                MetroFramework.MetroMessageBox.Show(this, "As variáveis comparadas devem ter o memso tipo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            switch((int)m_CbxCondition.SelectedValue)
            {
                case 0://">"
                    {
                        if(m_Argument1.Type == PropertyType.Boolean)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Não se pode comparar booleans com '>'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    break;

                case 1://"<"
                    {
                        if (m_Argument1.Type == PropertyType.Boolean)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Não se pode comparar booleans com '<'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    break;
            }

            return true;
        }

        #endregion
    }
}
