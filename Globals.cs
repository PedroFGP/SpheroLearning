using Sphero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sphero_Learning
{
    //Arquivo responsável por conter as classes ditas como globais utilizadas pelo aplicação como um todo

    public enum PropertyType
    {
        Object,
        Integer,
        Float,
        Boolean,
        String
    };

    public class Property
    {
        private string m_Description;
        private object m_Value;
        private PropertyType m_Type;
        private SpheroCommandPacket m_SpheroCommand = null;

        public string Name
        {
            get { return m_Description; }

            set { m_Description = value; }
        }

        public object Value
        {
            get { return m_Value; }

            set { m_Value = value; }
        }

        public PropertyType Type
        {
            get { return m_Type; }

            set { m_Type = value; }
        }

        public SpheroCommandPacket SpheroCommand
        {
            get { return m_SpheroCommand; }

            set { m_SpheroCommand = value; }
        }

        public Property()
        {
        }

        public Property(string p_Description, object p_Value, PropertyType p_Type)
        {
            m_Description = p_Description;
            m_Value = p_Value;
            m_Type = p_Type;
        }
        
        public string propertyToString()
        {
            string v_Return = m_Description;

            string v_TypeValue = String.Empty;

            switch(Type)
            {
                case PropertyType.Integer:
                    {
                        v_TypeValue = String.Format(" - <Inteiro>({0})", (int)Value);
                    }
                    break;
                case PropertyType.Float:
                    {
                        v_TypeValue = String.Format(" - <Decimal>({0})", (float)Value);
                    }
                    break;
                case PropertyType.Boolean:
                    {
                        v_TypeValue = String.Format(" - <Falso/Verdadeiro>{0})", (Boolean)Value);
                    }
                    break;
                case PropertyType.String:
                    {
                        v_TypeValue = String.Format(" - <Texto>({0})", (string)Value);
                    }
                    break;
            }

            return v_Return += v_TypeValue;
        }
    }

    public class Condition
    {
        public string m_Description;
        public int m_Id;

        public string Description
        {
            get { return m_Description; }

            set { m_Description = value; }
        }

        public int ID
        {
            get { return m_Id; }

            set { m_Id = value; }
        }

        public Condition()
        {
        }

        public Condition(string p_Description, int p_Id)
        {
            m_Description = p_Description;
            m_Id = p_Id;
        }
    }

    public static class Globals
    {
        public static List<Property> m_Properties = new List<Property>();
        public static List<Condition> m_Conditions = new List<Condition>();

        public static SpheroCommandPacket GET_RGB_LED = new SpheroCommandPacket(SpheroCommand.CMD_GET_RGB_LED, (byte)SpheroCommand.CMD_GET_RGB_LED, new byte[] { 0x00 });
    }
}
