using Sphero_Learning.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Sphero_Learning.Blocks.Conditionals
{
    public class IfBlock : Block
    {
        #region Constructors & Properties

        //Variáveis globais, propriedades e construtor

        private Block m_GotoBlock = null;
        private Property m_Argument1;
        private Property m_Argument2;
        private Condition m_Condition;

        public Block GotoBlock
        {
            get { return m_GotoBlock; }

            set { m_GotoBlock = value; }
        }

        public Property Arugment1
        {
            get { return m_Argument1; }
        }

        public Property Arugment2
        {
            get { return m_Argument2; }
        }

        public IfBlock()
        {
            Type = BlockType.Conditional;

            IfBlockForm v_FillForm = new IfBlockForm();

            v_FillForm.ShowDialog();

            Valid = v_FillForm.Valid;

            m_Argument1 = v_FillForm.Argument1;
            m_Argument2 = v_FillForm.Argument2;
            m_Condition = v_FillForm.Condition;

            Text = String.Format("Se {0} {1} {2}", m_Argument1.Name, m_Condition.Description, m_Argument2.Name);

            v_FillForm.Dispose();
        }

        #endregion

        #region Methods

        //Método para avaliar se a expressão formada é verdadeira
        public bool evaluateExpression()
        {
            if (m_Argument1.SpheroCommand != null)
            {

            }

            switch (m_Condition.ID)
            {
                case 0://">"
                    {
                        return moreThan();
                    }
                    break;

                case 1://"<"
                    {
                        return lessThan();
                    }
                    break;

                case 2://">="
                    {
                        return moreOrEqualThan();
                    }
                    break;

                case 3://"<="
                    {
                        return lessOrEqualThan();
                    }
                    break;

                case 4://"=="
                    {
                        return equal();
                    }
                    break;

                case 5://"!="
                    {
                        return notEqual();
                    }
                    break;
            }

            return false;
        }

        //Métodos para cada condição com todas as combinações

        private bool moreThan()
        {
            if (m_Argument1.Type == PropertyType.Integer)
            {
                return ((int)m_Argument1.Value > (int)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Float)
            {
                return ((float)m_Argument1.Value > (float)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.String)
            {
                return (((string)m_Argument1.Value).Length > ((string)m_Argument2.Value).Length) ? true : false;
            }

            return false;
        }

        private bool lessThan()
        {
            if (m_Argument1.Type == PropertyType.Integer)
            {
                return ((int)m_Argument1.Value < (int)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Float)
            {
                return ((float)m_Argument1.Value < (float)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.String)
            {
                return (((string)m_Argument1.Value).Length < ((string)m_Argument2.Value).Length) ? true : false;
            }

            return false;
        }

        private bool moreOrEqualThan()
        {
            if (m_Argument1.Type == PropertyType.Integer)
            {
                return ((int)m_Argument1.Value >= (int)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Float)
            {
                return ((float)m_Argument1.Value >= (float)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Boolean)
            {
                return ((bool)m_Argument1.Value == (bool)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.String)
            {
                return (((string)m_Argument1.Value).Length >= ((string)m_Argument2.Value).Length) ? true : false;
            }

            return false;
        }

        private bool lessOrEqualThan()
        {
            if (m_Argument1.Type == PropertyType.Integer)
            {
                return ((int)m_Argument1.Value <= (int)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Float)
            {
                return ((float)m_Argument1.Value <= (float)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Boolean)
            {
                return ((bool)m_Argument1.Value == (bool)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.String)
            {
                return (((string)m_Argument1.Value).Length <= ((string)m_Argument2.Value).Length) ? true : false;
            }

            return false;
        }

        private bool equal()
        {
            if (m_Argument1.Type == PropertyType.Integer)
            {
                return ((int)m_Argument1.Value == (int)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Float)
            {
                return ((float)m_Argument1.Value == (float)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Boolean)
            {
                return ((bool)m_Argument1.Value == (bool)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.String)
            {
                return (((string)m_Argument1.Value).Equals(((string)m_Argument2.Value))) ? true : false;
            }

            return false;
        }

        private bool notEqual()
        {
            if (m_Argument1.Type == PropertyType.Integer)
            {
                return ((int)m_Argument1.Value != (int)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Float)
            {
                return ((float)m_Argument1.Value != (float)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.Boolean)
            {
                return ((bool)m_Argument1.Value != (bool)m_Argument2.Value) ? true : false;
            }
            else if (m_Argument1.Type == PropertyType.String)
            {
                return (((string)m_Argument1.Value).Equals(((string)m_Argument2.Value))) ? false : true;
            }

            return false;
        }

        //Método para detemrinar o último bloco que depende desse if
        public Block findLastChild(Block p_Parent)
        {
            if (p_Parent.Type != BlockType.Conditional)
            {
                return p_Parent;
            }

            if (((IfBlock)p_Parent).m_GotoBlock == null)
            {
                return p_Parent;
            }

            return findLastChild(((IfBlock)p_Parent).m_GotoBlock);
        }

        #endregion
    }
}
