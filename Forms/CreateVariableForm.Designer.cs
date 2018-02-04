namespace Sphero_Learning.Forms
{
    partial class CreateVariableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVariableForm));
            this.m_TbxVarName = new MetroFramework.Controls.MetroTextBox();
            this.m_LblType = new MetroFramework.Controls.MetroLabel();
            this.m_BtnCreate = new MetroFramework.Controls.MetroButton();
            this.m_BtnCancel = new MetroFramework.Controls.MetroButton();
            this.m_CbxVarType = new System.Windows.Forms.ComboBox();
            this.m_TbxVarValue = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // m_TbxVarName
            // 
            // 
            // 
            // 
            this.m_TbxVarName.CustomButton.Image = null;
            this.m_TbxVarName.CustomButton.Location = new System.Drawing.Point(452, 1);
            this.m_TbxVarName.CustomButton.Name = "";
            this.m_TbxVarName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_TbxVarName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_TbxVarName.CustomButton.TabIndex = 1;
            this.m_TbxVarName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_TbxVarName.CustomButton.UseSelectable = true;
            this.m_TbxVarName.CustomButton.Visible = false;
            this.m_TbxVarName.Lines = new string[0];
            this.m_TbxVarName.Location = new System.Drawing.Point(23, 63);
            this.m_TbxVarName.MaxLength = 32767;
            this.m_TbxVarName.Name = "m_TbxVarName";
            this.m_TbxVarName.PasswordChar = '\0';
            this.m_TbxVarName.PromptText = "Nome da variável...";
            this.m_TbxVarName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_TbxVarName.SelectedText = "";
            this.m_TbxVarName.SelectionLength = 0;
            this.m_TbxVarName.SelectionStart = 0;
            this.m_TbxVarName.ShortcutsEnabled = true;
            this.m_TbxVarName.Size = new System.Drawing.Size(474, 23);
            this.m_TbxVarName.TabIndex = 0;
            this.m_TbxVarName.UseSelectable = true;
            this.m_TbxVarName.WaterMark = "Nome da variável...";
            this.m_TbxVarName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_TbxVarName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_LblType
            // 
            this.m_LblType.AutoSize = true;
            this.m_LblType.Location = new System.Drawing.Point(23, 94);
            this.m_LblType.Name = "m_LblType";
            this.m_LblType.Size = new System.Drawing.Size(38, 19);
            this.m_LblType.TabIndex = 2;
            this.m_LblType.Text = "Tipo:";
            // 
            // m_BtnCreate
            // 
            this.m_BtnCreate.Location = new System.Drawing.Point(23, 154);
            this.m_BtnCreate.Name = "m_BtnCreate";
            this.m_BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.m_BtnCreate.TabIndex = 3;
            this.m_BtnCreate.Text = "Criar";
            this.m_BtnCreate.UseSelectable = true;
            this.m_BtnCreate.Click += new System.EventHandler(this.m_BtnCreate_Click);
            // 
            // m_BtnCancel
            // 
            this.m_BtnCancel.Highlight = true;
            this.m_BtnCancel.Location = new System.Drawing.Point(104, 154);
            this.m_BtnCancel.Name = "m_BtnCancel";
            this.m_BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_BtnCancel.TabIndex = 4;
            this.m_BtnCancel.Text = "Cancelar";
            this.m_BtnCancel.UseSelectable = true;
            this.m_BtnCancel.Click += new System.EventHandler(this.m_BtnCancel_Click);
            // 
            // m_CbxVarType
            // 
            this.m_CbxVarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_CbxVarType.FormattingEnabled = true;
            this.m_CbxVarType.Location = new System.Drawing.Point(67, 92);
            this.m_CbxVarType.Name = "m_CbxVarType";
            this.m_CbxVarType.Size = new System.Drawing.Size(429, 21);
            this.m_CbxVarType.TabIndex = 5;
            // 
            // m_TbxVarValue
            // 
            // 
            // 
            // 
            this.m_TbxVarValue.CustomButton.Image = null;
            this.m_TbxVarValue.CustomButton.Location = new System.Drawing.Point(452, 1);
            this.m_TbxVarValue.CustomButton.Name = "";
            this.m_TbxVarValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_TbxVarValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_TbxVarValue.CustomButton.TabIndex = 1;
            this.m_TbxVarValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_TbxVarValue.CustomButton.UseSelectable = true;
            this.m_TbxVarValue.CustomButton.Visible = false;
            this.m_TbxVarValue.Lines = new string[0];
            this.m_TbxVarValue.Location = new System.Drawing.Point(23, 119);
            this.m_TbxVarValue.MaxLength = 32767;
            this.m_TbxVarValue.Name = "m_TbxVarValue";
            this.m_TbxVarValue.PasswordChar = '\0';
            this.m_TbxVarValue.PromptText = "Valor da variável...";
            this.m_TbxVarValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_TbxVarValue.SelectedText = "";
            this.m_TbxVarValue.SelectionLength = 0;
            this.m_TbxVarValue.SelectionStart = 0;
            this.m_TbxVarValue.ShortcutsEnabled = true;
            this.m_TbxVarValue.Size = new System.Drawing.Size(474, 23);
            this.m_TbxVarValue.TabIndex = 6;
            this.m_TbxVarValue.UseSelectable = true;
            this.m_TbxVarValue.WaterMark = "Valor da variável...";
            this.m_TbxVarValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_TbxVarValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CreateVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 200);
            this.Controls.Add(this.m_TbxVarValue);
            this.Controls.Add(this.m_CbxVarType);
            this.Controls.Add(this.m_BtnCancel);
            this.Controls.Add(this.m_BtnCreate);
            this.Controls.Add(this.m_LblType);
            this.Controls.Add(this.m_TbxVarName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateVariableForm";
            this.Resizable = false;
            this.Text = "Criar Variável";
            this.Load += new System.EventHandler(this.frmCreateVariable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox m_TbxVarName;
        private MetroFramework.Controls.MetroLabel m_LblType;
        private MetroFramework.Controls.MetroButton m_BtnCreate;
        private MetroFramework.Controls.MetroButton m_BtnCancel;
        private System.Windows.Forms.ComboBox m_CbxVarType;
        private MetroFramework.Controls.MetroTextBox m_TbxVarValue;
    }
}