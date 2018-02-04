using Sphero;
using Sphero_Learning.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sphero_Learning.Blocks.Actions
{
    public class MoveBlock : Block
    {
        #region Constructor

        public MoveBlock()
        {
            Type = BlockType.Action;

            MoveBlockForm v_Form = new MoveBlockForm();

            v_Form.ShowDialog();

            Valid = v_Form.Valid;

            Text = "Move com velocidade " + v_Form.Speed + " virando para " + v_Form.Heading + "°";

            Command = new SpheroCommandPacket(SpheroCommand.CMD_ROLL, CommandSequencer.Next, v_Form.Speed, BitConverter.GetBytes(v_Form.Heading)[1], BitConverter.GetBytes(v_Form.Heading)[0], 0x01 );
        }

        #endregion
    }
}
