using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Sphero;
using Sphero_Learning.Forms;
using System.Windows.Forms;

namespace Sphero_Learning.Blocks.Actions
{
    public class ColorBlock : Block
    {
        #region Variables & Constructor

        //Variáveis globais e construtor

        private SolidBrush m_Color = new SolidBrush(Color.Black);

        public ColorBlock()
        {
            Type = BlockType.Action;

            Text = "Mudar cor";

            showColorPicker();

            Command = new SpheroCommandPacket(SpheroCommand.CMD_SET_RGB_LED, CommandSequencer.Next, new byte[] { m_Color.Color.R, m_Color.Color.G, m_Color.Color.B, 0x00 });
        }

        #endregion

        #region Methods

        //Método para mostrar o color picker
        private void showColorPicker()
        {
            ColorDialog v_ColorPicker = new ColorDialog();

            v_ColorPicker.AllowFullOpen = true;

            v_ColorPicker.ShowHelp = true;

            DialogResult v_Result = v_ColorPicker.ShowDialog();

            if (v_Result == DialogResult.OK)
            {
                m_Color = new SolidBrush(v_ColorPicker.Color);
            }
            else
            {
                Valid = false;
            }
        }

        //Método de sobrecarga para renderizar o bloco
        public override void draw(Graphics p_Graphics)
        {
            SizeF v_StrinSize = p_Graphics.MeasureString(Text, Font);
            Size v_CustomSize = new Size();

            v_CustomSize.Width = (int)v_StrinSize.Width + 9 + (int)v_StrinSize.Height;// 9 pixels de sobra

            v_CustomSize.Height = (int)v_StrinSize.Height + 4;// 8 pixels de sobra

            Size = v_CustomSize;

            p_Graphics.DrawRectangle(BorderColor, Position.X - 1, Position.Y - 1, Size.Width + 1, Size.Height + 1);

            p_Graphics.FillRectangle(BackgroundColor, Position.X, Position.Y, Size.Width, Size.Height);

            p_Graphics.DrawRectangle(BorderColor, Position.X + 6 + (int)v_StrinSize.Width, Position.Y + 3, (int)v_StrinSize.Height - 3, (int)v_StrinSize.Height - 3);

            p_Graphics.FillRectangle(m_Color, Position.X + 7 + (int)v_StrinSize.Width, Position.Y + 4, (int)v_StrinSize.Height - 4, (int)v_StrinSize.Height - 4);

            PointF v_StringPosition = new PointF(Position.X, Position.Y);

            p_Graphics.DrawString(Text, Font, ForeColor, v_StringPosition);
        }

        #endregion
    }
}
