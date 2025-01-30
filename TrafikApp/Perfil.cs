using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.ChatArchivos;
using TrafikApp.Componentes;
using TrafikApp.Model;

namespace TrafikApp
{
    public partial class Perfil : Form
    {
        private Usuario usuarioActual = new Usuario();
        private Cliente cliente;

        public Perfil()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            flechaAtras_button.FlatAppearance.BorderSize = 0;
            enviarMensaje_button.FlatAppearance.BorderSize = 0;
            cliente = new Cliente(this);
            //cliente.Conectar();
            this.AcceptButton = enviarMensaje_button;

        }

        public Cliente devolverCliente()
        {
            return cliente;
        }


        private async void enviarMensaje_button_Click(object sender, EventArgs e)
        {
            string mensaje = miMensaje_textBox.Text;
            if (!string.IsNullOrEmpty(mensaje))
            {
                await cliente.EnviarMensajeAsync(mensaje);
                miMensaje_textBox.Clear();
            }
            miMensaje_textBox.Focus();
        }

        public void MostrarMensaje(string mensaje)
        {
            listaMensajes.Items.Add(mensaje);
            listaMensajes.TopIndex = listaMensajes.Items.Count - 1;

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void flechaAtras_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        public async void setUsuarioActual(int id, string nombre, string apellido, string email, string contrasena, string rol)
        {
            usuarioActual.id = id;
            usuarioActual.nombre = nombre;
            usuarioActual.apellido = apellido;
            usuarioActual.email = email;
            usuarioActual.contrasena = contrasena;
            usuarioActual.rol = rol;

            if (cliente != null)
            {
                await cliente.CerrarConexionAsync();
            }

            cliente = new Cliente(this);
            cliente.nombreUsuario = usuarioActual.nombre;
            cliente.apellidoUsuario = usuarioActual.apellido;

            await cliente.ConectarAsync();

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

        private async void cerrarSesion_button_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                await cliente.CerrarConexionAsync();
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void miMensaje_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaMensajes_textbox_TextChanged(object sender, EventArgs e)
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
