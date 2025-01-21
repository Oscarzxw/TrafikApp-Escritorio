using System;
using System.Windows.Forms;
using TrafikApp.Componentes;
using TrafikApp.Model;

namespace TrafikApp
{
    public partial class Main : Form
    {
        ComponenteGestionarIncidencias componenteGestionarIncidencias = new ComponenteGestionarIncidencias();
        ComponenteGestionarUsuarios componenteGestionarUsuarios = new ComponenteGestionarUsuarios();
        private Usuario usuarioActual = new Usuario();

        
        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            cerrarSesion_button.FlatAppearance.BorderSize = 0;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cerrarSesion_button, "Cerrar Sesión");

            toolTip.InitialDelay = 500;
            toolTip.ShowAlways = true;
        }

        private void cerrarSesion_button_Click(object sender, EventArgs e)
        {
            usuarioActual = new Usuario();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gestionarIncidencias_button_Click(object sender, EventArgs e)
        {
            componentes_panel.Controls.Clear();
            componenteGestionarIncidencias.Dock = DockStyle.Fill;
            componentes_panel.Controls.Add(componenteGestionarIncidencias);
            gestionarUsuarios_button.Enabled = true;
            gestionarIncidencias_button.Enabled = false;
        }

        private void gestionarUsuarios_button_Click(object sender, EventArgs e)
        {
            componentes_panel.Controls.Clear();
            componenteGestionarUsuarios.Dock = DockStyle.Fill;
            componentes_panel.Controls.Add(componenteGestionarUsuarios);
            componenteGestionarUsuarios.setUsuarioActual(usuarioActual.id, usuarioActual.nombre, usuarioActual.apellido, usuarioActual.email, usuarioActual.contrasena, usuarioActual.rol);
            gestionarIncidencias_button.Enabled = true;
            gestionarUsuarios_button.Enabled = false;
        }

        public void setUsuarioActual(int id, string nombre, string apellido, string email, string contrasena, string rol)
        { 
            usuarioActual.id = id;
            usuarioActual.nombre = nombre;
            usuarioActual.apellido = apellido;
            usuarioActual.email = email;
            usuarioActual.contrasena = contrasena;
            usuarioActual.rol = rol;
        }

    }

}
