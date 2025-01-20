using System;
using System.Collections;
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
using TrafikApp.Repositorio;

namespace TrafikApp.Componentes
{
    public partial class ComponenteGestionarUsuarios : UserControl
    {
        private bool contrasenaMostrada = false;
        public ComponenteGestionarUsuarios()
        {
            InitializeComponent();
        }

        private void ComponenteGestionarUsuarios_Load(object sender, EventArgs e)
        {
            rol_comboBox.SelectedIndex = 0;
            rol_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            

            crearColumnasTablaUsuarios();
            rellenarTabla();
        }

        private async void rellenarTabla()
        {
            ArrayList usuarios = await GetJSON.recogerUsuarios();
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

        private async void anadirUsuario_button_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuario_textbox.Text.Trim();
            string apellidoUsuario = apellidoUsuario_textbox.Text.Trim();
            string emailUsuario = emailUsuario_textbox.Text.Trim();
            string contrasenaUsuario = contrasenaUsuario_textbox.Text.Trim();
            if (!nombreUsuario.Equals("") || !apellidoUsuario.Equals("") || !emailUsuario.Equals("") || !contrasenaUsuario.Equals(""))
            {
                string rol = "usuario";
                switch (rol_comboBox.SelectedIndex)
                {
                    case 0:
                        rol = "usuario";
                        break;
                    case 1:
                        rol = "admin";
                        break;
                }
                Usuario usuario = new Usuario(nombreUsuario, apellidoUsuario, emailUsuario, contrasenaUsuario, rol);
                bool usuarioCreada = await PostJSON.crearUsuario(usuario);
                reiniciarCampos();
                rellenarTabla();
            }
            
        }

        private async void eliminarUsuario_button_Click(object sender, EventArgs e)
        {
            string emailUsuario = emailUsuario_textbox.Text.Trim();

            if (!emailUsuario.Equals(""))
            {
                Usuario usuario = new Usuario("", "", emailUsuario, "", "");
                bool usuarioEliminado = await DeleteJSON.eliminarUsuario(usuario);
                reiniciarCampos();
                rellenarTabla();
            }
        }

        private void reiniciarCampos()
        {
            nombreUsuario_textbox.Clear();
            apellidoUsuario_textbox.Clear();
            emailUsuario_textbox.Clear();
            contrasenaUsuario_textbox.Clear();
            rol_comboBox.SelectedIndex = 0;
        }

        private void datosUsuarios_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = datosUsuarios_dataGrid.Rows[e.RowIndex];

                string nombreUsuario = filaSeleccionada.Cells["colNombre"].Value?.ToString();
                string apellidoUsuario = filaSeleccionada.Cells["colApellido"].Value?.ToString();
                string emailUsuario = filaSeleccionada.Cells["colEmail"].Value?.ToString();
                string rolUsuario = filaSeleccionada.Cells["colRol"].Value?.ToString();


                nombreUsuario_textbox.Text = nombreUsuario;
                apellidoUsuario_textbox.Text = apellidoUsuario;
                emailUsuario_textbox.Text = emailUsuario;
                
                if (rolUsuario.ToLower().Equals("admin"))
                {
                    rol_comboBox.SelectedIndex = 1;
                }
                else
                {
                    rol_comboBox.SelectedIndex = 0;
                }

            }
        }

        private async void modificarUsuario_button_Click(object sender, EventArgs e)
        {
            if (datosUsuarios_dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = datosUsuarios_dataGrid.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["colId"].Value);

                string nombreUsuario = nombreUsuario_textbox.Text.Trim();
                string apellidoUsuario = apellidoUsuario_textbox.Text.Trim();
                string emailUsuario = emailUsuario_textbox.Text.Trim();
                string contrasenaUsuario = contrasenaUsuario_textbox.Text.Trim();

                if (!string.IsNullOrEmpty(nombreUsuario) || !string.IsNullOrEmpty(apellidoUsuario) ||
                    !string.IsNullOrEmpty(emailUsuario))
                {
                    if (string.IsNullOrEmpty(contrasenaUsuario))
                    {
                        contrasenaUsuario = null;
                    }
                    string rol = "usuario";

                    switch (rol_comboBox.SelectedIndex)
                    {
                        case 0:
                            rol = "usuario";
                            break;
                        case 1:
                            rol = "admin";
                            break;
                    }

                    Usuario usuario = new Usuario(id, nombreUsuario, apellidoUsuario, emailUsuario, contrasenaUsuario, rol);

                    bool usuarioModificado = await PatchJSON.modificarUsuario(usuario);

                    reiniciarCampos();
                    rellenarTabla();
                    
                }
            }
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
                contrasenaUsuario_textbox.UseSystemPasswordChar = true;
                alternarContrasena_button.BackgroundImage = Image.FromFile(rutaImagenOjoCerrado);
                contrasenaMostrada = false;
            }
            else
            {
                contrasenaUsuario_textbox.UseSystemPasswordChar = false;
                alternarContrasena_button.BackgroundImage = Image.FromFile(rutaImagenOjoAbierto);
                contrasenaMostrada = true;
            }
        }
    }
}
