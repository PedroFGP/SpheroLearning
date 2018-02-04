using Sphero;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Sphero_Learning.Blocks
{
    #region Properties and Enum

    //Variáveis globais, propriedades e enumeração

    public enum BlockType
    {
        Default,
        Action,
        Conditional
    };

    public class Block
    {
        private SpheroCommandPacket m_CommandPacket;
        private string m_Description;
        private Point m_Position;
        private Size m_Size;
        private BlockType m_BlockType = BlockType.Default;
        private bool m_IsValid = true;

        private Font m_Font = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Bold);
        private Brush m_BackgroundColor = new SolidBrush(Color.FromArgb(255, 129, 207, 224));
        private Pen m_BorderColor = new Pen(Color.Black);
        private Brush m_ForeColor = new SolidBrush(Color.Black);

        public SpheroCommandPacket Command
        {
            get { return m_CommandPacket; }

            set { m_CommandPacket = value; }
        }

        public string Text
        {
            get { return m_Description; }

            set { m_Description = value; }
        }

        public Point Position
        {
            get { return m_Position; }

            set { m_Position = value; }
        }

        public BlockType Type
        {
            get { return m_BlockType; }

            set { m_BlockType = value; }
        }

        public Size Size
        {
            get { return m_Size; }

            set { m_Size = value; }
        }

        public bool Valid
        {
            get { return m_IsValid; }

            set { m_IsValid = value; }
        }

        public Font Font
        {
            get { return m_Font; }

            set { m_Font = value; }
        }

        public Brush BackgroundColor
        {
            get { return m_BackgroundColor; }

            set { m_BackgroundColor = value; }
        }

        public Pen BorderColor
        {
            get { return m_BorderColor; }

            set { m_BorderColor = value; }
        }

        public Brush ForeColor
        {
            get { return m_ForeColor; }

            set { m_ForeColor = value; }
        }

        #endregion

        //Método base para a renderização do bloco
        public virtual void draw(Graphics p_Graphics)
        {
            SizeF v_StrinSize = p_Graphics.MeasureString(m_Description, m_Font);

            m_Size.Width = (int)v_StrinSize.Width + 5;// 5 pixels de sobra

            m_Size.Height = (int)v_StrinSize.Height + 4;// 8 pixels de sobra

            p_Graphics.DrawRectangle(m_BorderColor, m_Position.X - 1, m_Position.Y - 1, m_Size.Width + 1, m_Size.Height + 1);

            p_Graphics.FillRectangle(m_BackgroundColor, m_Position.X, m_Position.Y, m_Size.Width, m_Size.Height);

            PointF v_StringPosition = new PointF(m_Position.X, m_Position.Y);

            p_Graphics.DrawString(m_Description, m_Font, m_ForeColor, v_StringPosition);
        }
    }
}
