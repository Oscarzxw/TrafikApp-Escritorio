using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.Model;
using TrafikApp.Repositorio;

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

            string mapFilePath = Path.Combine(projectDirectory, "TrafikApp", "Mapa", "map.html");

            mapa_webView2.Source = new Uri("file:///" + mapFilePath);
        }

        private void latitud_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void longitud_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComponenteGestionarIncidencias_Load(object sender, EventArgs e)
        {
            tipoIncidencia_comboBox.SelectedIndex = 0;
            tipoIncidencia_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            crearColumnasTablaIncidencias();
            rellenarTabla();
        }

        private void crearColumnasTablaIncidencias()
        {
            datosIncidencias_dataGrid.AutoGenerateColumns = false;

            datosIncidencias_dataGrid.Columns.Clear();

            datosIncidencias_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datosIncidencias_dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            datosIncidencias_dataGrid.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);


            datosIncidencias_dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13, FontStyle.Bold);
            datosIncidencias_dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCausa",
                HeaderText = "Causa"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTipo",
                HeaderText = "Tipo"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProvincia",
                HeaderText = "Provincia"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLatitud",
                HeaderText = "Latitud"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLongitud",
                HeaderText = "Longitud"
            });
        }

        private void reiniciarCampos()
        {
            causaIncidencia_textbox.Clear();
            tipoIncidencia_comboBox.SelectedIndex = 0;
            fechaInicio_date.Value = DateTime.Now;
            latitud_textBox.Clear();
            longitud_textBox.Clear();
        }

        private void eliminarincidencia_button_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
        }

        private async void anadirIncidencia_button_Click(object sender, EventArgs e)
        {
            string causaIncidencia = causaIncidencia_textbox.Text;
            string tipoIncidencia = tipoIncidencia_comboBox.SelectedItem.ToString();
            string fechaIncidencia = fechaInicio_date.ToString();
            string latitudIncidencia = latitud_textBox.Text.ToString().Replace(",", ".");
            string longitudIncidencia = longitud_textBox.Text.ToString().Replace(",", ".");
            if (!string.IsNullOrEmpty(causaIncidencia) && !string.IsNullOrEmpty(latitudIncidencia) && !string.IsNullOrEmpty(longitudIncidencia)) 
            {
                LocalizarIncidencia localizacion = await obtenerDatosLocalizacion(latitudIncidencia, longitudIncidencia);

                latitudIncidencia = latitud_textBox.Text.ToString();
                longitudIncidencia = longitud_textBox.Text.ToString();

                double latitud = Double.Parse(latitudIncidencia);
                double longitud = Double.Parse(longitudIncidencia);

                string cityTown;
                string province;
                string road;

                if(localizacion.address != null)
                {
                    if (!string.IsNullOrEmpty(localizacion.address.city))
                    {
                        cityTown = localizacion.address.city;
                    }
                    else
                    {
                        cityTown = "NOT FOUND";
                    }

                    if (!string.IsNullOrEmpty(localizacion.address.province))
                    {
                        province = localizacion.address.province;
                    }
                    else
                    {
                        province = "NOT FOUND";
                    }

                    if (!string.IsNullOrEmpty(localizacion.address.road))
                    {
                        road = localizacion.address.road;
                    }
                    else
                    {
                        road = "NOT FOUND";
                    }
                }
                else
                {
                    cityTown = "NOT FOUND";
                    province = "NOT FOUND";
                    road = "NOT FOUND";
                }
                

                Incidencia incidenciaCrear = new Incidencia(1, tipoIncidencia, province, causaIncidencia, cityTown, fechaIncidencia, road, latitud, longitud, true);

                bool incidenciaCreada = await PostJSON.crearIncidencia(incidenciaCrear);

                rellenarTabla();
                reiniciarCampos();
            }            
        }

        private void datosIncidencias_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = datosIncidencias_dataGrid.Rows[e.RowIndex];

                string causaIncidencia = filaSeleccionada.Cells["colCausa"].Value?.ToString();
                string tipoIncidencia = filaSeleccionada.Cells["colTipo"].Value?.ToString();
                string latitudIncidencia = filaSeleccionada.Cells["colLatitud"].Value?.ToString();
                string longitudIncidencia = filaSeleccionada.Cells["colLongitud"].Value?.ToString();


                causaIncidencia_textbox.Text = causaIncidencia;
                tipoIncidencia_comboBox.SelectedItem = tipoIncidencia;
                latitud_textBox.Text = latitudIncidencia;
                longitud_textBox.Text = longitudIncidencia;

            }

        }

        private void latitud_textBox_TextChanged(object sender, EventArgs e)
        {
            double numeroValido;
            
            if (Double.TryParse(latitud_textBox.Text, out numeroValido))
            {
                if (Double.Parse(latitud_textBox.Text) < 42.47)
                {
                    latitud_textBox.Text = "42,47";
                }
                else if (Double.Parse(latitud_textBox.Text) > 43.45)
                {
                    latitud_textBox.Text = "43,45";
                }
            }
            else
            {
                latitud_textBox.Text = "43";
            }
            
            marcarPosicionEnMapa();
        }

        private void longitud_textBox_TextChanged(object sender, EventArgs e)
        {
            double numeroValido;

            if (Double.TryParse(longitud_textBox.Text, out numeroValido))
            {
                if (Double.Parse(longitud_textBox.Text) < -3.44)
                {
                    longitud_textBox.Text = "-3,44";
                }
                else if (Double.Parse(longitud_textBox.Text) > -1.73)
                {
                    longitud_textBox.Text = "-1,73";
                }
            }
            else
            {
                longitud_textBox.Text = "-2,6";
            }

            marcarPosicionEnMapa();
        }

        private async void marcarPosicionEnMapa()
        {
            string latitudIncidencia = latitud_textBox.Text.ToString().Replace(",", ".");
            string longitudIncidencia = longitud_textBox.Text.ToString().Replace(",", ".");


            string script = $"marcarPosicion({latitudIncidencia.ToString(CultureInfo.InvariantCulture)}, {longitudIncidencia.ToString(CultureInfo.InvariantCulture)});";

            await mapa_webView2.EnsureCoreWebView2Async();
            await mapa_webView2.ExecuteScriptAsync(script);


        }

        private static async Task<LocalizarIncidencia> obtenerDatosLocalizacion(string latitud, string longitud)
        {
            string JSON_datos = "https://nominatim.openstreetmap.org/reverse?lat=" + latitud + "&lon=" + longitud + "&format=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "MiAplicacion/1.0 (tuemail@example.com)");
                    HttpResponseMessage response = await client.GetAsync(JSON_datos);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    LocalizarIncidencia datos = JsonConvert.DeserializeObject<LocalizarIncidencia>(responseBody);

                    return datos;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener datos: {ex.Message}");
                    return null;
                }
            }
        }
        private async void rellenarTabla()
        {
            ArrayList incidencias = await GetJSON.recogerIncidencias();
            datosIncidencias_dataGrid.Rows.Clear();

            foreach (Incidencia inci in incidencias)
            {
                var row = new DataGridViewRow();
                row.CreateCells(datosIncidencias_dataGrid);

                row.Cells[datosIncidencias_dataGrid.Columns["colId"].Index].Value = inci.incidenceId;
                row.Cells[datosIncidencias_dataGrid.Columns["colCausa"].Index].Value = inci.cause;
                row.Cells[datosIncidencias_dataGrid.Columns["colTipo"].Index].Value = inci.incidenceType;
                row.Cells[datosIncidencias_dataGrid.Columns["colProvincia"].Index].Value = inci.province;
                row.Cells[datosIncidencias_dataGrid.Columns["colLatitud"].Index].Value = inci.latitude;
                row.Cells[datosIncidencias_dataGrid.Columns["colLongitud"].Index].Value = inci.longitude;

                datosIncidencias_dataGrid.Rows.Add(row);
            }
        }
    }
}
