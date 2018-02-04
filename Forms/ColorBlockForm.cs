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
    public partial class ColorBlockForm : MetroFramework.Forms.MetroForm
    {
        public Color m_BlockColor;

        public ColorBlockForm()
        {
            InitializeComponent();
        }

        private void ColorBlockForm_Load(object sender, EventArgs e)
        {
            showColorPicker();
        }

        private void m_BtnChooseColor_Click(object sender, EventArgs e)
        {
            showColorPicker();
        }

        private void m_BtnOk_Click(object sender, EventArgs e)
        {
            m_BlockColor = m_PnlColor.BackColor;
            this.Close();
        }

        private void showColorPicker()
        {
            ColorDialog v_ColorPicker = new ColorDialog();

            v_ColorPicker.AllowFullOpen = true;

            v_ColorPicker.ShowHelp = true;

            DialogResult v_Result = v_ColorPicker.ShowDialog();

            if (v_Result == DialogResult.OK)
            {
                m_PnlColor.BackColor = v_ColorPicker.Color;
                m_BlockColor = v_ColorPicker.Color;
            }
        }
    }
}
