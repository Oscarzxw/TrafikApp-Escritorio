using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TrafikApp.Correo;
using TrafikApp.Model;
using TrafikApp.Repositorio;

namespace TrafikApp.Componentes
{
    public partial class ComponenteGestionarUsuarios : UserControl
    {
        private bool contrasenaMostrada = false;
        private Usuario usuarioActual = new Usuario();
        public ComponenteGestionarUsuarios()
        {
            InitializeComponent();
        }

        private void ComponenteGestionarUsuarios_Load(object sender, EventArgs e)
        {
            rol_comboBox.SelectedIndex = 0;
            rol_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            alternarContrasena_button.FlatAppearance.BorderSize = 0;


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
                row.DefaultCellStyle.BackColor = Color.LightGray;
                row.DefaultCellStyle.BackColor = Color.LightGray;

                if (usu.rol.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    row.HeaderCell.Style.BackColor = Color.Green;
                }
                else
                {
                    row.HeaderCell.Style.BackColor = Color.Blue;
                }
                

            }
        }

        private void crearColumnasTablaUsuarios()
        {
            datosUsuarios_dataGrid.AutoGenerateColumns = false;

            datosUsuarios_dataGrid.Columns.Clear();

            datosUsuarios_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datosUsuarios_dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            datosUsuarios_dataGrid.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);


            datosUsuarios_dataGrid.EnableHeadersVisualStyles = false;
            datosUsuarios_dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            datosUsuarios_dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

            bool emailExistente = false;
            string nombreUsuario = nombreUsuario_textbox.Text.Trim();
            string apellidoUsuario = apellidoUsuario_textbox.Text.Trim();
            string emailUsuario = emailUsuario_textbox.Text.Trim();
            string contrasenaUsuario = contrasenaUsuario_textbox.Text.Trim();
            foreach (DataGridViewRow row in datosUsuarios_dataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    string email = row.Cells["colEmail"].Value?.ToString();

                    if (!string.IsNullOrEmpty(email))
                    {
                        if (email.Equals(emailUsuario))
                        {
                            emailExistente = true;
                            break;
                        }
                    }
                }
            }
            if (!emailExistente)
            {
                if (!nombreUsuario.Equals("") && !apellidoUsuario.Equals("") && !emailUsuario.Equals("") && !contrasenaUsuario.Equals(""))
                {
                    string rol = "usuario";
                    if(rol_comboBox.SelectedIndex == 0)
                    {
                        rol = "usuario";
                    }
                    else if(rol_comboBox.SelectedIndex == 1)
                    {
                        rol = "admin";
                    }

                    Usuario usuario = new Usuario(nombreUsuario, apellidoUsuario, emailUsuario, contrasenaUsuario, rol);

                    bool usuarioCreada = await PostJSON.crearUsuario(usuario);

                    if (usuarioCreada)
                    {
                        Thread enviarCorreo = new Thread(() =>
                        {
                            EnviarCorreo.enviarCorreo(CuerposCorreos.mensajeBienvenida(usuario.nombre, usuario.apellido, usuario.rol), usuario.email);
                        });

                        enviarCorreo.IsBackground = true;
                        enviarCorreo.Start();

                        reiniciarCampos();
                        rellenarTabla();
                    }
                }
                else
                {
                    MessageBox.Show("Rellena todos los campos para poder añadir un nuevo usuario.");
                }
            }
            else
            {
                MessageBox.Show("Ese email ya existe.");
            }
            
        }

        
        private async void eliminarUsuario_button_Click(object sender, EventArgs e)
        {
            string emailUsuario = emailUsuario_textbox.Text.Trim();
            string nombreUsuario = nombreUsuario_textbox.Text;
            string apellidoUsuario = apellidoUsuario_textbox.Text;

            if (!emailUsuario.Equals(""))
            {
                if (!emailUsuario.Equals(usuarioActual.email))
                {
                    Usuario usuario = new Usuario("", "", emailUsuario, "", "");
                    bool usuarioEliminado = await DeleteJSON.eliminarUsuario(usuario);

                    if (usuarioEliminado)
                    {
                        Thread enviarCorreo = new Thread(() =>
                        {
                            EnviarCorreo.enviarCorreo(CuerposCorreos.mensajeDespedida(nombreUsuario, apellidoUsuario), usuario.email);
                        });

                        enviarCorreo.IsBackground = true;
                        enviarCorreo.Start();

                        reiniciarCampos();
                        rellenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No puedes eliminar tu propio usuario.");
                }
            }
            else{
                MessageBox.Show("Introduce un email para eliminar el usuario.");
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
                datosUsuarios_dataGrid.Rows[e.RowIndex].Selected = true;
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
                if (!filaSeleccionada.Cells["colEmail"].Value.ToString().Equals(usuarioActual.email))
                {
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

                        if(rol_comboBox.SelectedIndex == 0)
                        {
                            rol = "usuario";
                        }
                        else
                        {
                            rol = "admin";
                        }

                        Usuario usuario = new Usuario(id, nombreUsuario, apellidoUsuario, emailUsuario, contrasenaUsuario, rol);

                        bool usuarioModificado = await PatchJSON.modificarUsuario(usuario);

                        if (usuarioModificado)
                        {
                            reiniciarCampos();
                            rellenarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el usuario.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puedes modificar tu  propio usuario.");
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

        public void setUsuarioActual(int id, string nombre, string apellido, string email, string contrasena, string rol)
        {
            usuarioActual.id = id;
            usuarioActual.nombre = nombre;
            usuarioActual.apellido = apellido;
            usuarioActual.email = email;
            usuarioActual.contrasena = contrasena;
            usuarioActual.rol = rol;
        }
    }
}
