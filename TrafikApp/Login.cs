using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.Model;

namespace TrafikApp
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            salirApp_button.FlatAppearance.BorderSize = 0;

        }

        private void salirApp_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioSesion_button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            DialogResult result = main.ShowDialog();
            if (result == DialogResult.OK)
            {
                correo_textbox.Clear();
                contrasena_textbox.Clear();
                this.Show();
                correo_textbox.Focus();
            }
            else if (result == DialogResult.Cancel)
            {
                correo_textbox.Clear();
                contrasena_textbox.Clear();
                this.Show();
                correo_textbox.Focus();
            }

            string jsonFilePath = "http://localhost:8080/api/incidencias";

            // Leer el contenido del archivo JSON
            string jsonContent = File.ReadAllText(jsonFilePath);

            // Deserializar el contenido JSON en un objeto Persona
            Incidencia incidencia = JsonConvert.DeserializeObject<Incidencia>(jsonContent);

            // Acceder a los datos deserializados
            Console.WriteLine($"Nombre: {incidencia.id}");
        }
    }
}
