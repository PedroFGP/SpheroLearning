namespace Sphero_Learning.Forms
{
    partial class TurnBlockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnBlockForm));
            this.m_TrkHeading = new MetroFramework.Controls.MetroTrackBar();
            this.m_BtnAccept = new MetroFramework.Controls.MetroButton();
            this.m_LblHeadingAngle = new MetroFramework.Controls.MetroLabel();
            this.m_BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // m_TrkHeading
            // 
            this.m_TrkHeading.BackColor = System.Drawing.Color.Transparent;
            this.m_TrkHeading.Location = new System.Drawing.Point(23, 63);
            this.m_TrkHeading.Maximum = 359;
            this.m_TrkHeading.Name = "m_TrkHeading";
            this.m_TrkHeading.Size = new System.Drawing.Size(303, 21);
            this.m_TrkHeading.TabIndex = 0;
            this.m_TrkHeading.Value = 0;
            // 
            // m_BtnAccept
            // 
            this.m_BtnAccept.Location = new System.Drawing.Point(23, 100);
            this.m_BtnAccept.Name = "m_BtnAccept";
            this.m_BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.m_BtnAccept.TabIndex = 2;
            this.m_BtnAccept.Text = "Construir";
            this.m_BtnAccept.UseSelectable = true;
            this.m_BtnAccept.Click += new System.EventHandler(this.m_BtnAccept_Click);
            // 
            // m_LblHeadingAngle
            // 
            this.m_LblHeadingAngle.AutoSize = true;
            this.m_LblHeadingAngle.Location = new System.Drawing.Point(332, 63);
            this.m_LblHeadingAngle.Name = "m_LblHeadingAngle";
            this.m_LblHeadingAngle.Size = new System.Drawing.Size(21, 19);
            this.m_LblHeadingAngle.TabIndex = 3;
            this.m_LblHeadingAngle.Text = "0°";
            // 
            // m_BtnCancel
            // 
            this.m_BtnCancel.Location = new System.Drawing.Point(104, 100);
            this.m_BtnCancel.Name = "m_BtnCancel";
            this.m_BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_BtnCancel.TabIndex = 5;
            this.m_BtnCancel.Text = "Cancelar";
            this.m_BtnCancel.UseSelectable = true;
            this.m_BtnCancel.Click += new System.EventHandler(this.m_BtnCancel_Click);
            // 
            // TurnBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 140);
            this.Controls.Add(this.m_BtnCancel);
            this.Controls.Add(this.m_LblHeadingAngle);
            this.Controls.Add(this.m_BtnAccept);
            this.Controls.Add(this.m_TrkHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TurnBlockForm";
            this.Resizable = false;
            this.Text = "Bloco Virar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar m_TrkHeading;
        private MetroFramework.Controls.MetroButton m_BtnAccept;
        private MetroFramework.Controls.MetroLabel m_LblHeadingAngle;
        private MetroFramework.Controls.MetroButton m_BtnCancel;
    }
}