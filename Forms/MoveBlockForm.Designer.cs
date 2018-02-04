namespace Sphero_Learning.Forms
{
    partial class MoveBlockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveBlockForm));
            this.m_LblHeadingAngle = new MetroFramework.Controls.MetroLabel();
            this.m_TrkHeading = new MetroFramework.Controls.MetroTrackBar();
            this.m_BtnAccept = new MetroFramework.Controls.MetroButton();
            this.m_LblHeading = new MetroFramework.Controls.MetroLabel();
            this.m_LblSpeed = new MetroFramework.Controls.MetroLabel();
            this.m_LblSpeedValue = new MetroFramework.Controls.MetroLabel();
            this.m_TrkSpeed = new MetroFramework.Controls.MetroTrackBar();
            this.m_BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // m_LblHeadingAngle
            // 
            this.m_LblHeadingAngle.AutoSize = true;
            this.m_LblHeadingAngle.Location = new System.Drawing.Point(332, 82);
            this.m_LblHeadingAngle.Name = "m_LblHeadingAngle";
            this.m_LblHeadingAngle.Size = new System.Drawing.Size(21, 19);
            this.m_LblHeadingAngle.TabIndex = 5;
            this.m_LblHeadingAngle.Text = "0°";
            // 
            // m_TrkHeading
            // 
            this.m_TrkHeading.BackColor = System.Drawing.Color.Transparent;
            this.m_TrkHeading.Location = new System.Drawing.Point(23, 82);
            this.m_TrkHeading.Maximum = 359;
            this.m_TrkHeading.Name = "m_TrkHeading";
            this.m_TrkHeading.Size = new System.Drawing.Size(303, 21);
            this.m_TrkHeading.TabIndex = 4;
            this.m_TrkHeading.Value = 0;
            // 
            // m_BtnAccept
            // 
            this.m_BtnAccept.Location = new System.Drawing.Point(23, 167);
            this.m_BtnAccept.Name = "m_BtnAccept";
            this.m_BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.m_BtnAccept.TabIndex = 6;
            this.m_BtnAccept.Text = "Construir";
            this.m_BtnAccept.UseSelectable = true;
            this.m_BtnAccept.Click += new System.EventHandler(this.m_BtnAccept_Click);
            // 
            // m_LblHeading
            // 
            this.m_LblHeading.AutoSize = true;
            this.m_LblHeading.Location = new System.Drawing.Point(23, 60);
            this.m_LblHeading.Name = "m_LblHeading";
            this.m_LblHeading.Size = new System.Drawing.Size(57, 19);
            this.m_LblHeading.TabIndex = 7;
            this.m_LblHeading.Text = "Direção:";
            // 
            // m_LblSpeed
            // 
            this.m_LblSpeed.AutoSize = true;
            this.m_LblSpeed.Location = new System.Drawing.Point(23, 118);
            this.m_LblSpeed.Name = "m_LblSpeed";
            this.m_LblSpeed.Size = new System.Drawing.Size(76, 19);
            this.m_LblSpeed.TabIndex = 10;
            this.m_LblSpeed.Text = "Velocidade:";
            // 
            // m_LblSpeedValue
            // 
            this.m_LblSpeedValue.AutoSize = true;
            this.m_LblSpeedValue.Location = new System.Drawing.Point(332, 140);
            this.m_LblSpeedValue.Name = "m_LblSpeedValue";
            this.m_LblSpeedValue.Size = new System.Drawing.Size(16, 19);
            this.m_LblSpeedValue.TabIndex = 9;
            this.m_LblSpeedValue.Text = "0";
            // 
            // m_TrkSpeed
            // 
            this.m_TrkSpeed.BackColor = System.Drawing.Color.Transparent;
            this.m_TrkSpeed.Location = new System.Drawing.Point(23, 140);
            this.m_TrkSpeed.Maximum = 255;
            this.m_TrkSpeed.Name = "m_TrkSpeed";
            this.m_TrkSpeed.Size = new System.Drawing.Size(303, 21);
            this.m_TrkSpeed.TabIndex = 8;
            this.m_TrkSpeed.Value = 0;
            // 
            // m_BtnCancel
            // 
            this.m_BtnCancel.Location = new System.Drawing.Point(104, 167);
            this.m_BtnCancel.Name = "m_BtnCancel";
            this.m_BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_BtnCancel.TabIndex = 11;
            this.m_BtnCancel.Text = "Cancelar";
            this.m_BtnCancel.UseSelectable = true;
            this.m_BtnCancel.Click += new System.EventHandler(this.m_BtnCancel_Click);
            // 
            // MoveBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 210);
            this.Controls.Add(this.m_BtnCancel);
            this.Controls.Add(this.m_LblSpeed);
            this.Controls.Add(this.m_LblSpeedValue);
            this.Controls.Add(this.m_TrkSpeed);
            this.Controls.Add(this.m_LblHeading);
            this.Controls.Add(this.m_BtnAccept);
            this.Controls.Add(this.m_LblHeadingAngle);
            this.Controls.Add(this.m_TrkHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveBlockForm";
            this.Resizable = false;
            this.Text = "Bloco Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel m_LblHeadingAngle;
        private MetroFramework.Controls.MetroTrackBar m_TrkHeading;
        private MetroFramework.Controls.MetroButton m_BtnAccept;
        private MetroFramework.Controls.MetroLabel m_LblHeading;
        private MetroFramework.Controls.MetroLabel m_LblSpeed;
        private MetroFramework.Controls.MetroLabel m_LblSpeedValue;
        private MetroFramework.Controls.MetroTrackBar m_TrkSpeed;
        private MetroFramework.Controls.MetroButton m_BtnCancel;
    }
}