namespace Sphero_Learning.Forms
{
    partial class ColorBlockForm
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
            this.m_PnlColor = new MetroFramework.Controls.MetroPanel();
            this.m_BtnChooseColor = new MetroFramework.Controls.MetroButton();
            this.m_BtnOk = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // m_PnlColor
            // 
            this.m_PnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PnlColor.HorizontalScrollbarBarColor = true;
            this.m_PnlColor.HorizontalScrollbarHighlightOnWheel = false;
            this.m_PnlColor.HorizontalScrollbarSize = 19;
            this.m_PnlColor.Location = new System.Drawing.Point(242, 138);
            this.m_PnlColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_PnlColor.Name = "m_PnlColor";
            this.m_PnlColor.Size = new System.Drawing.Size(550, 42);
            this.m_PnlColor.TabIndex = 0;
            this.m_PnlColor.VerticalScrollbarBarColor = true;
            this.m_PnlColor.VerticalScrollbarHighlightOnWheel = false;
            this.m_PnlColor.VerticalScrollbarSize = 20;
            // 
            // m_BtnChooseColor
            // 
            this.m_BtnChooseColor.Location = new System.Drawing.Point(46, 138);
            this.m_BtnChooseColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_BtnChooseColor.Name = "m_BtnChooseColor";
            this.m_BtnChooseColor.Size = new System.Drawing.Size(150, 44);
            this.m_BtnChooseColor.TabIndex = 1;
            this.m_BtnChooseColor.Text = "Escolher Cor";
            this.m_BtnChooseColor.UseSelectable = true;
            this.m_BtnChooseColor.Click += new System.EventHandler(this.m_BtnChooseColor_Click);
            // 
            // m_BtnOk
            // 
            this.m_BtnOk.Location = new System.Drawing.Point(644, 221);
            this.m_BtnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_BtnOk.Name = "m_BtnOk";
            this.m_BtnOk.Size = new System.Drawing.Size(150, 44);
            this.m_BtnOk.TabIndex = 2;
            this.m_BtnOk.Text = "Construir";
            this.m_BtnOk.UseSelectable = true;
            this.m_BtnOk.Click += new System.EventHandler(this.m_BtnOk_Click);
            // 
            // ColorBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 288);
            this.Controls.Add(this.m_BtnOk);
            this.Controls.Add(this.m_BtnChooseColor);
            this.Controls.Add(this.m_PnlColor);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ColorBlockForm";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Text = "Bloco Cor";
            this.Load += new System.EventHandler(this.ColorBlockForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel m_PnlColor;
        private MetroFramework.Controls.MetroButton m_BtnChooseColor;
        private MetroFramework.Controls.MetroButton m_BtnOk;
    }
}