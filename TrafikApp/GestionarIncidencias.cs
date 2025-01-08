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

namespace TrafikApp
{
    public partial class GestionarIncidencias : Form
    {
        public GestionarIncidencias()
        {
            InitializeComponent();

            mapa_webBrowser.Navigate("C:\\Users\\2dam3\\Desktop\\Oscar\\RETO\\DESIN\\TrafikApp\\TrafikApp\\Mapa\\map.html");


        }

        private void GestionarIncidencias_Load(object sender, EventArgs e)
        {
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(rutaBase);
        }
    }
}
