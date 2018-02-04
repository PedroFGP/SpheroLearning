using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Sphero_Learning.Forms
{
    public partial class CreateVariableForm : MetroForm
    {
        #region Constructors & Properties

        //Variáveis globais, propriedades e construtor

        private Property m_Property = null;

        public Property NewProperty
        {
            get { return m_Property; }
        }

        public CreateVariableForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        //Evento de carregamento do formulário
        private void frmCreateVariable_Load(object sender, EventArgs e)
        {
            fillTypeCombobox();
        }

        //Evento de click do botão create para criar um nova variável
        private void m_BtnCreate_Click(object sender, EventArgs e)
        {
            if(validateNewProperty())
            {
                this.Close();
            }
        }

        //Evento de click do botão cancel
        private void m_BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        //Método para preencher o combobox de tipos possíveis para uma variável
        private void fillTypeCombobox()
        {
            List<KeyValuePair<PropertyType, string>> v_VarTypes = new List<KeyValuePair<PropertyType, string>>();

            v_VarTypes.Add(new KeyValuePair<PropertyType, string>(PropertyType.String, "Texto"));
            v_VarTypes.Add(new KeyValuePair<PropertyType, string>(PropertyType.Integer, "Inteiro"));
            v_VarTypes.Add(new KeyValuePair<PropertyType, string>(PropertyType.Float, "Decimal"));
            v_VarTypes.Add(new KeyValuePair<PropertyType, string>(PropertyType.Boolean, "Falso/Verdadeiro"));

            m_CbxVarType.DataSource = new BindingSource(v_VarTypes, null).DataSource;
            m_CbxVarType.DisplayMember = "Value";
            m_CbxVarType.ValueMember = "Key";
        }

        //Método responsável por validar a nova variável antes de inserí la na lista de variáveis
        private bool validateNewProperty()
        {
            if (String.IsNullOrEmpty(m_TbxVarName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Nome da variável não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(Globals.m_Properties.Where(i_Property => i_Property.Name.Equals(m_TbxVarName.Text)).Count() > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Já existe uma outra variável com esse nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            m_Property = new Property();

            m_Property.Name = m_TbxVarName.Text;
            m_Property.Type = (PropertyType)m_CbxVarType.SelectedValue;

            switch(m_Property.Type)
            {
                case PropertyType.String:
                    {
                        m_Property.Value = m_TbxVarValue.Text;
                    }
                    break;

                case PropertyType.Integer:
                    {
                        int v_Value;

                        if(int.TryParse(m_TbxVarValue.Text, out v_Value))
                        {
                            m_Property.Value = v_Value;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "O valor não é um inteiro válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            m_Property = null;
                            return false;
                        }
                    }
                    break;

                case PropertyType.Float:
                    {
                        float v_Value;

                        if(float.TryParse(m_TbxVarValue.Text, out v_Value))
                        {
                            m_Property.Value = v_Value;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "O valor não é um decimal válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            m_Property = null;
                            return false;
                        }
                    }
                    break;

                case PropertyType.Boolean:
                    {
                        bool v_Value;

                        if (bool.TryParse(m_TbxVarValue.Text, out v_Value))
                        {
                            m_Property.Value = v_Value;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "O valor não é um Falso/Verdadeiro válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            m_Property = null;
                            return false;
                        }
                    }
                    break;
            }

            return true;
        }

        #endregion
    }
}
