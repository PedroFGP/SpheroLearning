using Sphero;
using Sphero_Learning.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sphero_Learning.Blocks.Actions
{
    public class TurnBlock : Block
    {
        #region Constructor

        public TurnBlock()
        {
            Type = BlockType.Action;

            TurnBlockForm v_Form = new TurnBlockForm();

            v_Form.ShowDialog();

            Valid = v_Form.Valid;

            Text = "Girar para " + v_Form.Heading + "°";

            Command = new SpheroCommandPacket(SpheroCommand.CMD_ROLL, CommandSequencer.Next, 0x00, BitConverter.GetBytes(v_Form.Heading)[1], BitConverter.GetBytes(v_Form.Heading)[0], 0x00);
        }

        #endregion
    }
}
