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

            // Subir un nivel para obtener el directorio raíz del proyecto
            string parentDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory = Directory.GetParent(parentDirectory).Parent.FullName;

            // Ahora puedes combinar con la ruta relativa que necesites
            string mapFilePath = Path.Combine(projectDirectory,"TrafikApp", "Mapa", "map.html");

            mapa_webView2.Source = new Uri("file:///" + mapFilePath);
        }

        private void anadirIncidencia_button_Click(object sender, EventArgs e)
        {

        }
    }
}
