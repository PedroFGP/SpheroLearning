namespace Sphero_Learning
{
    partial class m_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Se");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Condições", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Mover");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("MudarCor");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Virar");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ações", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Propriedades");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Variáveis");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m_MainForm));
            this.m_MainPanel = new MetroFramework.Controls.MetroPanel();
            this.m_TvBlocks = new System.Windows.Forms.TreeView();
            this.m_LblSpheroStatus = new MetroFramework.Controls.MetroLabel();
            this.m_BtnRemoveLastBlock = new MetroFramework.Controls.MetroButton();
            this.m_BtnRun = new System.Windows.Forms.Button();
            this.m_BtnSleep = new System.Windows.Forms.Button();
            this.m_LblLog = new MetroFramework.Controls.MetroLabel();
            this.m_PnlLog = new MetroFramework.Controls.MetroPanel();
            this.m_TbxLog = new System.Windows.Forms.RichTextBox();
            this.m_BtnCreateVar = new MetroFramework.Controls.MetroButton();
            this.m_BtnRemoveVar = new MetroFramework.Controls.MetroButton();
            this.m_PnlLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_MainPanel
            // 
            this.m_MainPanel.AllowDrop = true;
            this.m_MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_MainPanel.HorizontalScrollbarBarColor = true;
            this.m_MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.m_MainPanel.HorizontalScrollbarSize = 10;
            this.m_MainPanel.Location = new System.Drawing.Point(182, 101);
            this.m_MainPanel.Name = "m_MainPanel";
            this.m_MainPanel.Size = new System.Drawing.Size(595, 370);
            this.m_MainPanel.TabIndex = 0;
            this.m_MainPanel.VerticalScrollbarBarColor = true;
            this.m_MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.m_MainPanel.VerticalScrollbarSize = 10;
            this.m_MainPanel.CustomPaint += new System.EventHandler<MetroFramework.Drawing.MetroPaintEventArgs>(this.m_MainPanel_CustomPaint);
            this.m_MainPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.m_MainPanel_DragDrop);
            this.m_MainPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.m_MainPanel_DragEnter);
            // 
            // m_TvBlocks
            // 
            this.m_TvBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_TvBlocks.Location = new System.Drawing.Point(23, 101);
            this.m_TvBlocks.Name = "m_TvBlocks";
            treeNode1.Name = "m_NodeIf";
            treeNode1.Text = "Se";
            treeNode2.Name = "m_NodeCondition";
            treeNode2.Text = "Condições";
            treeNode3.Name = "m_NodeMove";
            treeNode3.Text = "Mover";
            treeNode4.Name = "m_NodeChangeColor";
            treeNode4.Text = "MudarCor";
            treeNode5.Name = "m_NodeTurn";
            treeNode5.Text = "Virar";
            treeNode6.Name = "m_NodeActions";
            treeNode6.Text = "Ações";
            treeNode7.Name = "m_NodeProperties";
            treeNode7.Text = "Propriedades";
            treeNode8.Name = "m_NodeVariables";
            treeNode8.Text = "Variáveis";
            this.m_TvBlocks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode7,
            treeNode8});
            this.m_TvBlocks.Size = new System.Drawing.Size(153, 389);
            this.m_TvBlocks.TabIndex = 1;
            this.m_TvBlocks.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.m_TvBlocks_ItemDrag);
            this.m_TvBlocks.DragDrop += new System.Windows.Forms.DragEventHandler(this.m_TvBlocks_DragDrop);
            this.m_TvBlocks.DragEnter += new System.Windows.Forms.DragEventHandler(this.m_TvBlocks_DragEnter);
            // 
            // m_LblSpheroStatus
            // 
            this.m_LblSpheroStatus.AutoSize = true;
            this.m_LblSpheroStatus.Location = new System.Drawing.Point(211, 75);
            this.m_LblSpheroStatus.Name = "m_LblSpheroStatus";
            this.m_LblSpheroStatus.Size = new System.Drawing.Size(54, 19);
            this.m_LblSpheroStatus.TabIndex = 3;
            this.m_LblSpheroStatus.Text = "Sphero:";
            // 
            // m_BtnRemoveLastBlock
            // 
            this.m_BtnRemoveLastBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_BtnRemoveLastBlock.Location = new System.Drawing.Point(23, 496);
            this.m_BtnRemoveLastBlock.Name = "m_BtnRemoveLastBlock";
            this.m_BtnRemoveLastBlock.Size = new System.Drawing.Size(153, 23);
            this.m_BtnRemoveLastBlock.TabIndex = 5;
            this.m_BtnRemoveLastBlock.Text = "Remover Útlimo Bloco";
            this.m_BtnRemoveLastBlock.UseSelectable = true;
            this.m_BtnRemoveLastBlock.Click += new System.EventHandler(this.m_BtnRemoveLastBlock_Click);
            // 
            // m_BtnRun
            // 
            this.m_BtnRun.BackColor = System.Drawing.Color.Transparent;
            this.m_BtnRun.BackgroundImage = global::Sphero_Learning.Properties.Resources.play_button;
            this.m_BtnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_BtnRun.FlatAppearance.BorderSize = 0;
            this.m_BtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BtnRun.Location = new System.Drawing.Point(23, 75);
            this.m_BtnRun.Name = "m_BtnRun";
            this.m_BtnRun.Size = new System.Drawing.Size(23, 23);
            this.m_BtnRun.TabIndex = 7;
            this.m_BtnRun.UseVisualStyleBackColor = false;
            this.m_BtnRun.Click += new System.EventHandler(this.m_BtnRun_Click);
            // 
            // m_BtnSleep
            // 
            this.m_BtnSleep.BackColor = System.Drawing.Color.Transparent;
            this.m_BtnSleep.BackgroundImage = global::Sphero_Learning.Properties.Resources.Sleep;
            this.m_BtnSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_BtnSleep.Enabled = false;
            this.m_BtnSleep.FlatAppearance.BorderSize = 0;
            this.m_BtnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BtnSleep.Location = new System.Drawing.Point(182, 75);
            this.m_BtnSleep.Name = "m_BtnSleep";
            this.m_BtnSleep.Size = new System.Drawing.Size(23, 23);
            this.m_BtnSleep.TabIndex = 8;
            this.m_BtnSleep.UseVisualStyleBackColor = false;
            this.m_BtnSleep.Click += new System.EventHandler(this.m_BtnSleep_Click);
            // 
            // m_LblLog
            // 
            this.m_LblLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_LblLog.AutoSize = true;
            this.m_LblLog.Location = new System.Drawing.Point(182, 474);
            this.m_LblLog.Name = "m_LblLog";
            this.m_LblLog.Size = new System.Drawing.Size(34, 19);
            this.m_LblLog.TabIndex = 10;
            this.m_LblLog.Text = "Log:";
            // 
            // m_PnlLog
            // 
            this.m_PnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PnlLog.Controls.Add(this.m_TbxLog);
            this.m_PnlLog.HorizontalScrollbarBarColor = true;
            this.m_PnlLog.HorizontalScrollbarHighlightOnWheel = false;
            this.m_PnlLog.HorizontalScrollbarSize = 10;
            this.m_PnlLog.Location = new System.Drawing.Point(182, 496);
            this.m_PnlLog.Name = "m_PnlLog";
            this.m_PnlLog.Size = new System.Drawing.Size(595, 81);
            this.m_PnlLog.TabIndex = 11;
            this.m_PnlLog.VerticalScrollbarBarColor = true;
            this.m_PnlLog.VerticalScrollbarHighlightOnWheel = false;
            this.m_PnlLog.VerticalScrollbarSize = 10;
            // 
            // m_TbxLog
            // 
            this.m_TbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TbxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_TbxLog.Location = new System.Drawing.Point(0, 0);
            this.m_TbxLog.Name = "m_TbxLog";
            this.m_TbxLog.ReadOnly = true;
            this.m_TbxLog.Size = new System.Drawing.Size(593, 79);
            this.m_TbxLog.TabIndex = 2;
            this.m_TbxLog.Text = "";
            // 
            // m_BtnCreateVar
            // 
            this.m_BtnCreateVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_BtnCreateVar.Location = new System.Drawing.Point(23, 525);
            this.m_BtnCreateVar.Name = "m_BtnCreateVar";
            this.m_BtnCreateVar.Size = new System.Drawing.Size(153, 23);
            this.m_BtnCreateVar.TabIndex = 12;
            this.m_BtnCreateVar.Text = "Criar Variável";
            this.m_BtnCreateVar.UseSelectable = true;
            this.m_BtnCreateVar.Click += new System.EventHandler(this.m_BtnCreateVar_Click);
            // 
            // m_BtnRemoveVar
            // 
            this.m_BtnRemoveVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_BtnRemoveVar.Location = new System.Drawing.Point(23, 554);
            this.m_BtnRemoveVar.Name = "m_BtnRemoveVar";
            this.m_BtnRemoveVar.Size = new System.Drawing.Size(153, 23);
            this.m_BtnRemoveVar.TabIndex = 13;
            this.m_BtnRemoveVar.Text = "Remover Variável";
            this.m_BtnRemoveVar.UseSelectable = true;
            this.m_BtnRemoveVar.Click += new System.EventHandler(this.m_BtnRemoveVar_Click);
            // 
            // m_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.m_BtnRemoveVar);
            this.Controls.Add(this.m_BtnCreateVar);
            this.Controls.Add(this.m_PnlLog);
            this.Controls.Add(this.m_LblLog);
            this.Controls.Add(this.m_BtnSleep);
            this.Controls.Add(this.m_BtnRun);
            this.Controls.Add(this.m_BtnRemoveLastBlock);
            this.Controls.Add(this.m_LblSpheroStatus);
            this.Controls.Add(this.m_TvBlocks);
            this.Controls.Add(this.m_MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "m_MainForm";
            this.Text = "Sphero Learning";
            this.Load += new System.EventHandler(this.m_MainForm_Load);
            this.m_PnlLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel m_MainPanel;
        private System.Windows.Forms.TreeView m_TvBlocks;
        private MetroFramework.Controls.MetroLabel m_LblSpheroStatus;
        private MetroFramework.Controls.MetroButton m_BtnRemoveLastBlock;
        private System.Windows.Forms.Button m_BtnRun;
        private System.Windows.Forms.Button m_BtnSleep;
        private MetroFramework.Controls.MetroLabel m_LblLog;
        private MetroFramework.Controls.MetroPanel m_PnlLog;
        private System.Windows.Forms.RichTextBox m_TbxLog;
        private MetroFramework.Controls.MetroButton m_BtnCreateVar;
        private MetroFramework.Controls.MetroButton m_BtnRemoveVar;
    }
}

