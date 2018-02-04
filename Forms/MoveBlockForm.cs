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
    public partial class MoveBlockForm : MetroFramework.Forms.MetroForm
    {
        #region Constructor & Properties

        //Variáveis globais, propriedades e construtor

        private Int16 m_Angle = 0;
        private byte m_Speed = 0;
        private bool m_Validated = false;

        public Int16 Heading
        {
            get { return m_Angle; }
        }

        public byte Speed
        {
            get { return m_Speed; }
        }

        public bool Valid
        {
            get { return m_Validated; }

            set { m_Validated = value; }
        }

        public MoveBlockForm()
        {
            InitializeComponent();

            m_TrkHeading.ValueChanged += m_TrkHeading_ValueChanged;
            m_TrkSpeed.ValueChanged += m_TrkSpeed_ValueChanged;
        }

        #endregion

        #region Events

        //Evento de mudança do valor do trackbar de direção
        private void m_TrkHeading_ValueChanged(object sender, EventArgs e)
        {
            m_Angle = (Int16)m_TrkHeading.Value;

            m_LblHeadingAngle.Text = m_TrkHeading.Value + "°";
        }

        //Evento de mudança do valor do trackbar de velocidade
        private void m_TrkSpeed_ValueChanged(object sender, EventArgs e)
        {
            m_Speed = (byte)m_TrkSpeed.Value;

            m_LblSpeedValue.Text = m_TrkSpeed.Value.ToString();
        }

        //Evento de click do botão accept para a construção do novo block Mover
        private void m_BtnAccept_Click(object sender, EventArgs e)
        {
            m_Validated = true;

            this.Close();
        }

        //Evento de click do botão cancel para cancelar a criação do bloco
        private void m_BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
