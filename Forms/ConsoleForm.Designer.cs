namespace Sphero_Learning.Forms
{
    partial class ConsoleForm
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
            this.m_RTbxLog = new System.Windows.Forms.RichTextBox();
            this.m_CbxFilter = new System.Windows.Forms.ComboBox();
            this.m_LblFilter = new MetroFramework.Controls.MetroLabel();
            this.m_BtnExecute = new MetroFramework.Controls.MetroButton();
            this.m_TbxCommand = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // m_RTbxLog
            // 
            this.m_RTbxLog.Location = new System.Drawing.Point(23, 93);
            this.m_RTbxLog.Name = "m_RTbxLog";
            this.m_RTbxLog.Size = new System.Drawing.Size(454, 350);
            this.m_RTbxLog.TabIndex = 0;
            this.m_RTbxLog.Text = "";
            // 
            // m_CbxFilter
            // 
            this.m_CbxFilter.FormattingEnabled = true;
            this.m_CbxFilter.Items.AddRange(new object[] {
            "Tudo",
            "Enviado",
            "Recebido"});
            this.m_CbxFilter.Location = new System.Drawing.Point(71, 68);
            this.m_CbxFilter.Name = "m_CbxFilter";
            this.m_CbxFilter.Size = new System.Drawing.Size(208, 21);
            this.m_CbxFilter.TabIndex = 1;
            // 
            // m_LblFilter
            // 
            this.m_LblFilter.AutoSize = true;
            this.m_LblFilter.Location = new System.Drawing.Point(23, 68);
            this.m_LblFilter.Name = "m_LblFilter";
            this.m_LblFilter.Size = new System.Drawing.Size(42, 19);
            this.m_LblFilter.TabIndex = 2;
            this.m_LblFilter.Text = "Filtro:";
            // 
            // m_BtnExecute
            // 
            this.m_BtnExecute.Location = new System.Drawing.Point(402, 454);
            this.m_BtnExecute.Name = "m_BtnExecute";
            this.m_BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.m_BtnExecute.TabIndex = 3;
            this.m_BtnExecute.Text = "Executar";
            this.m_BtnExecute.UseSelectable = true;
            // 
            // m_TbxCommand
            // 
            // 
            // 
            // 
            this.m_TbxCommand.CustomButton.Image = null;
            this.m_TbxCommand.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.m_TbxCommand.CustomButton.Name = "";
            this.m_TbxCommand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_TbxCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_TbxCommand.CustomButton.TabIndex = 1;
            this.m_TbxCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_TbxCommand.CustomButton.UseSelectable = true;
            this.m_TbxCommand.CustomButton.Visible = false;
            this.m_TbxCommand.Lines = new string[0];
            this.m_TbxCommand.Location = new System.Drawing.Point(23, 454);
            this.m_TbxCommand.MaxLength = 32767;
            this.m_TbxCommand.Name = "m_TbxCommand";
            this.m_TbxCommand.PasswordChar = '\0';
            this.m_TbxCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_TbxCommand.SelectedText = "";
            this.m_TbxCommand.SelectionLength = 0;
            this.m_TbxCommand.SelectionStart = 0;
            this.m_TbxCommand.ShortcutsEnabled = true;
            this.m_TbxCommand.Size = new System.Drawing.Size(373, 23);
            this.m_TbxCommand.TabIndex = 4;
            this.m_TbxCommand.UseSelectable = true;
            this.m_TbxCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_TbxCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.m_TbxCommand);
            this.Controls.Add(this.m_BtnExecute);
            this.Controls.Add(this.m_LblFilter);
            this.Controls.Add(this.m_CbxFilter);
            this.Controls.Add(this.m_RTbxLog);
            this.Name = "ConsoleForm";
            this.Text = "Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_RTbxLog;
        private System.Windows.Forms.ComboBox m_CbxFilter;
        private MetroFramework.Controls.MetroLabel m_LblFilter;
        private MetroFramework.Controls.MetroButton m_BtnExecute;
        private MetroFramework.Controls.MetroTextBox m_TbxCommand;
    }
}