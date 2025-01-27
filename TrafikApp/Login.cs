
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TrafikApp.Model;
using TrafikApp.Repositorio;

namespace TrafikApp
{
    public partial class Login : Form
    {
        private bool contrasenaMostrada = false;
        public Login()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            salirApp_button.FlatAppearance.BorderSize = 0;
            alternarContrasena_button.FlatAppearance.BorderSize = 0;

        }

        private void salirApp_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void inicioSesion_button_Click(object sender, EventArgs e)
        {
            Usuario usuario = await PostJSON.obtenerUsuarioLogin(email_textbox.Text.Trim(), contrasena_textbox.Text.Trim());
            if (usuario != null && usuario.rol.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                Main main = new Main();
                main.setUsuarioActual(usuario.id, usuario.nombre, usuario.apellido,usuario.email,usuario.contrasena,usuario.rol);
                DialogResult result = main.ShowDialog();
                this.Hide();
                
                if (result == DialogResult.OK)
                {
                    email_textbox.Clear();
                    contrasena_textbox.Clear();
                    mensajeErrorLogin_label.Text = "";
                    this.Show();
                    email_textbox.Focus();
                }
                else if (result == DialogResult.Cancel)
                {
                    email_textbox.Clear();
                    contrasena_textbox.Clear();
                    mensajeErrorLogin_label.Text = "";
                    this.Show();
                    email_textbox.Focus();
                }
            }
            else{
                mensajeErrorLogin_label.ForeColor = System.Drawing.Color.Red;
                mensajeErrorLogin_label.Text = "El email o contraseña no son correctos o debes de ser administrador.";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void alternarContrasena_button_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string parentDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory = Directory.GetParent(parentDirectory).Parent.FullName;

            string rutaImagenOjoAbierto = Path.Combine(projectDirectory, "TrafikApp", "Sources", "ojoAbiertoContrasenaImagen.png");
            string rutaImagenOjoCerrado = Path.Combine(projectDirectory, "TrafikApp", "Sources", "ojoCerradoContrasenaImagen.png");

            if (contrasenaMostrada)
            {
                contrasena_textbox.UseSystemPasswordChar = true;
                alternarContrasena_button.BackgroundImage = Image.FromFile(rutaImagenOjoCerrado);
                contrasenaMostrada = false;
            }
            else{
                contrasena_textbox.UseSystemPasswordChar = false;
                alternarContrasena_button.BackgroundImage = Image.FromFile(rutaImagenOjoAbierto);
                contrasenaMostrada = true;
            }
        }
    }
}
