namespace Sphero_Learning.Forms
{
    partial class IfBlockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IfBlockForm));
            this.m_BtnAccept = new MetroFramework.Controls.MetroButton();
            this.m_LblIf = new MetroFramework.Controls.MetroLabel();
            this.m_LblPreview = new MetroFramework.Controls.MetroLabel();
            this.m_LblLine1 = new MetroFramework.Controls.MetroLabel();
            this.m_LblLine2 = new MetroFramework.Controls.MetroLabel();
            this.m_CbxArgument1 = new System.Windows.Forms.ComboBox();
            this.m_CbxCondition = new System.Windows.Forms.ComboBox();
            this.m_CbxArgument2 = new System.Windows.Forms.ComboBox();
            this.m_BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // m_BtnAccept
            // 
            this.m_BtnAccept.Location = new System.Drawing.Point(14, 155);
            this.m_BtnAccept.Name = "m_BtnAccept";
            this.m_BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.m_BtnAccept.TabIndex = 1;
            this.m_BtnAccept.Text = "Construir";
            this.m_BtnAccept.UseSelectable = true;
            this.m_BtnAccept.Click += new System.EventHandler(this.m_BtnAccept_Click);
            // 
            // m_LblIf
            // 
            this.m_LblIf.AutoSize = true;
            this.m_LblIf.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_LblIf.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.m_LblIf.Location = new System.Drawing.Point(14, 67);
            this.m_LblIf.Name = "m_LblIf";
            this.m_LblIf.Size = new System.Drawing.Size(43, 25);
            this.m_LblIf.TabIndex = 5;
            this.m_LblIf.Text = "Se...";
            // 
            // m_LblPreview
            // 
            this.m_LblPreview.AutoSize = true;
            this.m_LblPreview.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.m_LblPreview.Location = new System.Drawing.Point(14, 113);
            this.m_LblPreview.Name = "m_LblPreview";
            this.m_LblPreview.Size = new System.Drawing.Size(67, 19);
            this.m_LblPreview.TabIndex = 6;
            this.m_LblPreview.Text = "Preview:";
            // 
            // m_LblLine1
            // 
            this.m_LblLine1.AutoSize = true;
            this.m_LblLine1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_LblLine1.Location = new System.Drawing.Point(238, 63);
            this.m_LblLine1.Name = "m_LblLine1";
            this.m_LblLine1.Size = new System.Drawing.Size(31, 25);
            this.m_LblLine1.TabIndex = 7;
            this.m_LblLine1.Text = "->";
            // 
            // m_LblLine2
            // 
            this.m_LblLine2.AutoSize = true;
            this.m_LblLine2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_LblLine2.Location = new System.Drawing.Point(451, 63);
            this.m_LblLine2.Name = "m_LblLine2";
            this.m_LblLine2.Size = new System.Drawing.Size(31, 25);
            this.m_LblLine2.TabIndex = 9;
            this.m_LblLine2.Text = "->";
            // 
            // m_CbxArgument1
            // 
            this.m_CbxArgument1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_CbxArgument1.FormattingEnabled = true;
            this.m_CbxArgument1.Location = new System.Drawing.Point(67, 67);
            this.m_CbxArgument1.Name = "m_CbxArgument1";
            this.m_CbxArgument1.Size = new System.Drawing.Size(165, 21);
            this.m_CbxArgument1.TabIndex = 10;
            this.m_CbxArgument1.SelectedIndexChanged += new System.EventHandler(this.m_CbxArgument1_SelectedIndexChanged);
            // 
            // m_CbxCondition
            // 
            this.m_CbxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_CbxCondition.FormattingEnabled = true;
            this.m_CbxCondition.Location = new System.Drawing.Point(275, 67);
            this.m_CbxCondition.Name = "m_CbxCondition";
            this.m_CbxCondition.Size = new System.Drawing.Size(170, 21);
            this.m_CbxCondition.TabIndex = 11;
            this.m_CbxCondition.SelectedIndexChanged += new System.EventHandler(this.m_CbxCondition_SelectedIndexChanged);
            // 
            // m_CbxArgument2
            // 
            this.m_CbxArgument2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_CbxArgument2.FormattingEnabled = true;
            this.m_CbxArgument2.Location = new System.Drawing.Point(488, 67);
            this.m_CbxArgument2.Name = "m_CbxArgument2";
            this.m_CbxArgument2.Size = new System.Drawing.Size(165, 21);
            this.m_CbxArgument2.TabIndex = 12;
            this.m_CbxArgument2.SelectedIndexChanged += new System.EventHandler(this.m_CbxArgument2_SelectedIndexChanged);
            // 
            // m_BtnCancel
            // 
            this.m_BtnCancel.Location = new System.Drawing.Point(95, 155);
            this.m_BtnCancel.Name = "m_BtnCancel";
            this.m_BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_BtnCancel.TabIndex = 13;
            this.m_BtnCancel.Text = "Cancelar";
            this.m_BtnCancel.UseSelectable = true;
            this.m_BtnCancel.Click += new System.EventHandler(this.m_BtnCancel_Click);
            // 
            // IfBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 200);
            this.Controls.Add(this.m_BtnCancel);
            this.Controls.Add(this.m_CbxArgument2);
            this.Controls.Add(this.m_CbxCondition);
            this.Controls.Add(this.m_CbxArgument1);
            this.Controls.Add(this.m_LblLine2);
            this.Controls.Add(this.m_LblLine1);
            this.Controls.Add(this.m_LblPreview);
            this.Controls.Add(this.m_LblIf);
            this.Controls.Add(this.m_BtnAccept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IfBlockForm";
            this.Resizable = false;
            this.Text = "Bloco Se";
            this.Load += new System.EventHandler(this.IfBlockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton m_BtnAccept;
        private MetroFramework.Controls.MetroLabel m_LblIf;
        private MetroFramework.Controls.MetroLabel m_LblPreview;
        private MetroFramework.Controls.MetroLabel m_LblLine1;
        private MetroFramework.Controls.MetroLabel m_LblLine2;
        private System.Windows.Forms.ComboBox m_CbxArgument1;
        private System.Windows.Forms.ComboBox m_CbxCondition;
        private System.Windows.Forms.ComboBox m_CbxArgument2;
        private MetroFramework.Controls.MetroButton m_BtnCancel;
    }
}