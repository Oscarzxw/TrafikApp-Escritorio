using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.Componentes;
using TrafikApp.Model;

namespace TrafikApp
{
    public partial class Perfil : Form
    {
        private Usuario usuarioActual = new Usuario();

        public Perfil()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            flechaAtras_button.FlatAppearance.BorderSize = 0;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void flechaAtras_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void setUsuarioActual(int id, string nombre, string apellido, string email, string contrasena, string rol)
        {
            usuarioActual.id = id;
            usuarioActual.nombre = nombre;
            usuarioActual.apellido = apellido;
            usuarioActual.email = email;
            usuarioActual.contrasena = contrasena;
            usuarioActual.rol = rol;

            rellenarDatos();
        }

        private void rellenarDatos() { 
        
            nombreApellido_Label.Text = usuarioActual.nombre + " " + usuarioActual.apellido;
            correo_Label.Text = usuarioActual.email;

            if(usuarioActual.rol.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                rol_label.Text = "ADMINISTRADOR";
            }
            else
            {
                rol_label.Text = "USUARIO";
            }
            
        }

        private void cerrarSesion_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
