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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrafikApp
{
    public partial class Main : Form
    {
        ComponenteGestionarIncidencias componenteGestionarIncidencias = new ComponenteGestionarIncidencias();
        ComponenteGestionarUsuarios componenteGestionarUsuarios = new ComponenteGestionarUsuarios();
        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            cerrarSesion_button.FlatAppearance.BorderSize = 0;

            //Para quie se muestre un mensaje cuando se mentiene el cursor encima de un elemento
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(cerrarSesion_button, "Cerrar Sesión");

            // Tiempo de espera para que salga el mensaje
            toolTip.InitialDelay = 500;
            toolTip.ShowAlways = true;
        }

        private void cerrarSesion_button_Click(object sender, EventArgs e)
        {
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
            gestionarIncidencias_button.Enabled = true;
            gestionarUsuarios_button.Enabled = false;
        }

       
    }
}
