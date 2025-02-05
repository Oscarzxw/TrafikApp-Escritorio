
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TrafikApp.ChatArchivos;
using TrafikApp.Componentes;
using TrafikApp.Model;

namespace TrafikApp
{
    public partial class Main : Form
    {
        ComponenteGestionarIncidencias componenteGestionarIncidencias = new ComponenteGestionarIncidencias();
        ComponenteGestionarUsuarios componenteGestionarUsuarios = new ComponenteGestionarUsuarios();
        private Usuario usuarioActual = new Usuario();
        private ContextMenuStrip menuDesplegable;
        private Cliente cliente;
        private Perfil perfil = new Perfil();


        public Main()
        {
            InitializeComponent();

            menuDesplegable = new ContextMenuStrip();
            menuDesplegable.Font = new Font("Arial", 12, FontStyle.Bold);

            
            ToolStripMenuItem opcionVerPerfil = new ToolStripMenuItem("Perfil", Properties.Resources.usuarioLogoGestionarImg);
            ToolStripMenuItem opcionCerrarSesion = new ToolStripMenuItem("Cerrar Sesión", Properties.Resources.cerrarSesionImg);

            opcionVerPerfil.Click += opcionPerfil_Click;
            opcionCerrarSesion.Click += opcionCerrarSesion_Click;

            
            menuDesplegable.Items.Add(opcionVerPerfil);
            menuDesplegable.Items.Add(opcionCerrarSesion);

            verPerfil_button.ContextMenuStrip = menuDesplegable;

            this.FormBorderStyle = FormBorderStyle.None;
            verPerfil_button.FlatAppearance.BorderSize = 0;
            

        }
        private async void opcionCerrarSesion_Click(object sender, EventArgs e)
        {
            usuarioActual = new Usuario();
            this.DialogResult = DialogResult.OK;

            if (cliente != null)
            {
                await cliente.CerrarConexionAsync();
            }

            this.Close();
        }

        private void opcionPerfil_Click(object sender, EventArgs e)
        {
            
            perfil.setUsuarioActual(usuarioActual.id, usuarioActual.nombre, usuarioActual.apellido, usuarioActual.email, usuarioActual.contrasena, usuarioActual.rol);
            DialogResult result = perfil.ShowDialog();
            this.Hide();
            if(result == DialogResult.OK)
            {
                cliente = perfil.devolverCliente();
                this.Show();
            }
            else
            {
                usuarioActual = new Usuario();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
            ToolStripLabel nombreUsuario = new ToolStripLabel(usuarioActual.nombre + " " + usuarioActual.apellido);
            menuDesplegable.Items.Insert(0, nombreUsuario);

            componentes_panel.Controls.Clear();
            componenteGestionarUsuarios.Dock = DockStyle.Fill;
            componentes_panel.Controls.Add(componenteGestionarUsuarios);
            componenteGestionarUsuarios.setUsuarioActual(usuarioActual.id, usuarioActual.nombre, usuarioActual.apellido, usuarioActual.email, usuarioActual.contrasena, usuarioActual.rol);
            gestionarIncidencias_button.Enabled = true;
            gestionarUsuarios_button.Enabled = false;

        }

        private void verPerfil_button_Click(object sender, EventArgs e)
        {
            menuDesplegable.Show(verPerfil_button, new Point(0, verPerfil_button.Height));
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (cliente != null)
            {
                await cliente.CerrarConexionAsync();
            }
            base.OnFormClosing(e);
        }
    }

}
