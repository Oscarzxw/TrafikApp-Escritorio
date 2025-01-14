using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikApp.Componentes
{
    public partial class ComponenteGestionarUsuarios : UserControl
    {
        public ComponenteGestionarUsuarios()
        {
            InitializeComponent();
        }

        private void ComponenteGestionarUsuarios_Load(object sender, EventArgs e)
        {
            rol_comboBox.SelectedIndex = 0;
            rol_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void anadirUsuario_button_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }

        private void eliminarUsuario_button_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }

        private void reiniciarCampos()
        {
            nombreUsuario_textbox.Clear();
            apellidoUsuario_textbox.Clear();
            emailUsuario_textbox.Clear();
            contrasenaUsuario_textbox.Clear();
            rol_comboBox.SelectedIndex = 0;
        }
    }
}
