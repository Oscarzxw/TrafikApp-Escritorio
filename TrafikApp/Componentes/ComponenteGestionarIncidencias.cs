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

namespace TrafikApp.Componentes
{
    public partial class ComponenteGestionarIncidencias : UserControl
    {
        public ComponenteGestionarIncidencias()
        {
            InitializeComponent();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string parentDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory = Directory.GetParent(parentDirectory).Parent.FullName;

            string mapFilePath = Path.Combine(projectDirectory,"TrafikApp", "Mapa", "map.html");

            mapa_webView2.Source = new Uri("file:///" + mapFilePath);
        }

        private void anadirIncidencia_button_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }

        private void latitud_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void longitud_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComponenteGestionarIncidencias_Load(object sender, EventArgs e)
        {
            tipoIncidencia_comboBox.SelectedIndex = 0;
            tipoIncidencia_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void reiniciarCampos()
        {
            tituloIncidencia_textbox.Clear();
            descripcionIncidencia_textbox.Clear();
            tipoIncidencia_comboBox.SelectedIndex = 0;
            fechaInicio_date.Value = DateTime.Now;
            fechaFinal_date.Value = DateTime.Now;
            latitud_textBox.Clear();
            longitud_textBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }
    }
}
