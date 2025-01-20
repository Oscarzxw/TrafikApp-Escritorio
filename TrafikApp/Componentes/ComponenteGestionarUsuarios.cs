using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.Model;
using TrafikApp.Repositorio;

namespace TrafikApp.Componentes
{
    public partial class ComponenteGestionarUsuarios : UserControl
    {
        public ComponenteGestionarUsuarios()
        {
            InitializeComponent();
        }

        private async void ComponenteGestionarUsuarios_Load(object sender, EventArgs e)
        {
            rol_comboBox.SelectedIndex = 0;
            rol_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ArrayList usuarios = await GetJSON.recogerUsuarios();

            crearColumnasTablaUsuarios();

            datosUsuarios_dataGrid.Rows.Clear();

            foreach (Usuario usu in usuarios)
            {
                var row = new DataGridViewRow();
                row.CreateCells(datosUsuarios_dataGrid);

                row.Cells[datosUsuarios_dataGrid.Columns["colId"].Index].Value = usu.id;
                row.Cells[datosUsuarios_dataGrid.Columns["colNombre"].Index].Value = usu.nombre;
                row.Cells[datosUsuarios_dataGrid.Columns["colApellido"].Index].Value = usu.apellido;
                row.Cells[datosUsuarios_dataGrid.Columns["colEmail"].Index].Value = usu.email;
                row.Cells[datosUsuarios_dataGrid.Columns["colRol"].Index].Value = usu.rol;

                datosUsuarios_dataGrid.Rows.Add(row);
            }
        }

        private void crearColumnasTablaUsuarios()
        {
            datosUsuarios_dataGrid.AutoGenerateColumns = false;

            datosUsuarios_dataGrid.Columns.Clear();

            datosUsuarios_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datosUsuarios_dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            datosUsuarios_dataGrid.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);


            datosUsuarios_dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13, FontStyle.Bold);
            datosUsuarios_dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datosUsuarios_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID"
            });

            datosUsuarios_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre"
            });

            datosUsuarios_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colApellido",
                HeaderText = "Apellido"
            });

            datosUsuarios_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email"
            });

            datosUsuarios_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRol",
                HeaderText = "Rol"
            });
        }

        private void anadirUsuario_button_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }

        private void eliminarUsuario_button_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }

        private void reiniciarCampos()
        {
            nombreUsuario_textbox.Clear();
            apellidoUsuario_textbox.Clear();
            emailUsuario_textbox.Clear();
            contrasenaUsuario_textbox.Clear();
            rol_comboBox.SelectedIndex = 0;
        }
    }
}
