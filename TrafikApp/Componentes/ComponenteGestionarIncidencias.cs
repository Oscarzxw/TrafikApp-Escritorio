using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.Model;
using TrafikApp.Repositorio;

namespace TrafikApp.Componentes
{
    /**
     *  Es el componente encargado de gestionar las incidencias
     */

    public partial class ComponenteGestionarIncidencias : UserControl
    {
        string incidenceIdSeleccionada;

        /**
         * Es el constructor del componente
         */

        public ComponenteGestionarIncidencias()
        {
            InitializeComponent();

        }

        /**
         * Esta funcion limita los caracteres que se pueden introducir en el campo de latitud
         */
        private void latitud_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /**
         * Esta funcion limita los caracteres que se pueden introducir en el campo de longitud
         */

        private void longitud_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /**
         * Esta funcion se ejecuta cunado el formulario se inicializa
         */


        private async void ComponenteGestionarIncidencias_Load(object sender, EventArgs e)
        {
            tipoIncidencia_comboBox.SelectedIndex = 0;
            tipoIncidencia_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            crearColumnasTablaIncidencias();
            rellenarTabla();

            await mapa_webView2.EnsureCoreWebView2Async();

            string htmlContent = Properties.Resources.map;
            mapa_webView2.NavigateToString(htmlContent);

            mapa_webView2.CoreWebView2.WebMessageReceived += Mapa_WebMessageReceived;
        }

        /**
         * Esta funcion se encarga de crear las columnas de la tabla de las incidencias
         */

        private void crearColumnasTablaIncidencias()
        {
            
            datosIncidencias_dataGrid.AutoGenerateColumns = false;

            datosIncidencias_dataGrid.Columns.Clear();

            datosIncidencias_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datosIncidencias_dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            datosIncidencias_dataGrid.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);


            datosIncidencias_dataGrid.EnableHeadersVisualStyles = false;
            datosIncidencias_dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            datosIncidencias_dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
                Name = "colCiudad",
                HeaderText = "Ciudad"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRoad",
                HeaderText = "Road"
            });

            datosIncidencias_dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "Fecha"
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

        /**
         * Esta funcion se encarga de reiniciar los campos
         */

        private void reiniciarCampos()
        {
            causaIncidencia_textbox.Clear();
            tipoIncidencia_comboBox.SelectedIndex = 0;
            fechaInicio_date.Value = DateTime.Now;
            latitud_textBox.Clear();
            longitud_textBox.Clear();
        }

        /**
         * Esta funcion se encarga de eliminar la incidencia seleccionada en la tabla. Si la incidencia no es creada por nosotros no se podrá eliminar.
         */

        private async void eliminarincidencia_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(incidenceIdSeleccionada))
            {
                if(incidenceIdSeleccionada.Contains("-creada"))
                {
                    bool incidenciaEliminada = await DeleteJSON.eliminarIncidencia(incidenceIdSeleccionada.Trim());

                    if (incidenciaEliminada)
                    {
                        reiniciarCampos();
                        rellenarTabla();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se pueden eliminar incidencias creadas.");
                }
            }
            else
            {
                MessageBox.Show("Necesitas seleccionar una incidencia de la tabla.");
            }
            
        }

        /**
         * Esta funcion se encarga de añadir la incidencia mediante la API
         */

        private async void anadirIncidencia_button_Click(object sender, EventArgs e)
        {
            string causaIncidencia = causaIncidencia_textbox.Text;
            string tipoIncidencia = tipoIncidencia_comboBox.SelectedItem.ToString();
            string fechaIncidencia = fechaInicio_date.Value.ToString();
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

                int sourceId = buscarSourceId(cityTown, province);

                Incidencia incidenciaCrear = new Incidencia(sourceId, tipoIncidencia, province, causaIncidencia, cityTown, fechaIncidencia, road, latitud, longitud, true);

                bool incidenciaCreada = await PostJSON.crearIncidencia(incidenciaCrear);

                if (incidenciaCreada)
                {
                    rellenarTabla();
                    reiniciarCampos();
                }
                else
                {
                    MessageBox.Show("Error al crear la incidencia.");
                }

                
            }
            else
            {
                MessageBox.Show("Rellena todos los campos para añadir la incidencia.");
            }            
        }


        /**
         * Esta funcion se ejecuta cuando se pulsa un celda de la tabla
         */

        private void datosIncidencias_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                datosIncidencias_dataGrid.Rows[e.RowIndex].Selected = true;
                DataGridViewRow filaSeleccionada = datosIncidencias_dataGrid.Rows[e.RowIndex];

                string causaIncidencia = filaSeleccionada.Cells["colCausa"].Value?.ToString();
                string tipoIncidencia = filaSeleccionada.Cells["colTipo"].Value?.ToString();
                string latitudIncidencia = filaSeleccionada.Cells["colLatitud"].Value?.ToString();
                string longitudIncidencia = filaSeleccionada.Cells["colLongitud"].Value?.ToString();
                incidenceIdSeleccionada = filaSeleccionada.Cells["colId"].Value?.ToString();


                causaIncidencia_textbox.Text = causaIncidencia;
                tipoIncidencia_comboBox.SelectedItem = tipoIncidencia;
                latitud_textBox.Text = latitudIncidencia;
                longitud_textBox.Text = longitudIncidencia;

            }

        }
        /**
         * Esta funcion se ejecuta cuando el texto de la latitud cambia dejando introducir latitudes limitadas
         */

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

        /**
       * Esta funcion se ejecuta cuando el texto de la latitud cambia dejando introducir longitudes limitadas
       */
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

        /**
         * Esta funcion se encarga de marcar la posicion en el mapa segun la latitud y longitud insertada por el usuario
         */
        private async void marcarPosicionEnMapa()
        {
            string latitudIncidencia = latitud_textBox.Text.ToString().Replace(",", ".");
            string longitudIncidencia = longitud_textBox.Text.ToString().Replace(",", ".");


            string script = $"marcarPosicion({latitudIncidencia.ToString(CultureInfo.InvariantCulture)}, {longitudIncidencia.ToString(CultureInfo.InvariantCulture)});";

            await mapa_webView2.EnsureCoreWebView2Async();
            await mapa_webView2.ExecuteScriptAsync(script);


        }
        /**
         * Esta funcion recive datos de una API para obtener dfatos adicionales sobre una ubicacion exacta
         */

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

        /**
         * Esta funcion se encarga de rellenar los campos de la tabla poniendo colores especificos segun el tipo de incidencia
         */
        private async void rellenarTabla()
        {
            List<Incidencia> incidencias = await GetJSON.recogerIncidencias();
            datosIncidencias_dataGrid.Rows.Clear();

            foreach (Incidencia inci in incidencias)
            {
                var row = new DataGridViewRow();
                row.CreateCells(datosIncidencias_dataGrid);

                row.Cells[datosIncidencias_dataGrid.Columns["colId"].Index].Value = inci.incidenceId;
                row.Cells[datosIncidencias_dataGrid.Columns["colCausa"].Index].Value = inci.cause;
                row.Cells[datosIncidencias_dataGrid.Columns["colTipo"].Index].Value = inci.incidenceType;
                row.Cells[datosIncidencias_dataGrid.Columns["colProvincia"].Index].Value = inci.province;
                row.Cells[datosIncidencias_dataGrid.Columns["colCiudad"].Index].Value = inci.cityTown;
                row.Cells[datosIncidencias_dataGrid.Columns["colRoad"].Index].Value = inci.road;
                row.Cells[datosIncidencias_dataGrid.Columns["colFecha"].Index].Value = inci.startDate;
                row.Cells[datosIncidencias_dataGrid.Columns["colLatitud"].Index].Value = inci.latitude;
                row.Cells[datosIncidencias_dataGrid.Columns["colLongitud"].Index].Value = inci.longitude;

                datosIncidencias_dataGrid.Rows.Add(row);

                row.DefaultCellStyle.BackColor = Color.LightGray;

                switch (inci.incidenceType)
                {
                    case "EVEN":
                        row.HeaderCell.Style.BackColor = Color.Blue;
                        break;
                    case "OBRA":
                        row.HeaderCell.Style.BackColor = Color.Cyan;
                        break;
                    case "ACCIDENTE":
                        row.HeaderCell.Style.BackColor = Color.Red;
                        break;
                    case "CALLE CORTADA":
                        row.HeaderCell.Style.BackColor = Color.Green;
                        break;
                    case "OTRO":
                        row.HeaderCell.Style.BackColor = Color.Black;
                        break;
                    default:
                        row.HeaderCell.Style.BackColor = Color.White;
                        break;
                }
            }
        }
        /**
         * Esta funcion recoge infirmacion al script del mapa
         */

        private void Mapa_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                var mensaje = JsonConvert.DeserializeObject<Dictionary<string, string>>(e.WebMessageAsJson);

                if (mensaje != null && mensaje.ContainsKey("lat") && mensaje.ContainsKey("lng"))
                {
                    string latitud = mensaje["lat"];
                    string longitud = mensaje["lng"];

                    latitud_textBox.Text = latitud.Replace(".", ",");
                    longitud_textBox.Text = longitud.Replace(".", ",");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar el mensaje del mapa: {ex.Message}");
            }
        }

        /**
         * Esta funcion se encarga de generar un informe
         */

        private async void generarInforme_button_Click(object sender, EventArgs e)
        {
            List<Incidencia> incidencias = await GetJSON.recogerIncidencias();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Informe de Incidencias";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GenerarInforme.generarInforme(incidencias, saveFileDialog.FileName);
            }
            else
            {
                Console.WriteLine("Creación de informe cancelado.");
            }
        }

        /**
         * Esta funcion se encarga de modificar una incidencia segun la ID
         */

        private async void modificarIncidencia_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(incidenceIdSeleccionada))
            {
                string causaIncidencia = causaIncidencia_textbox.Text;
                string tipoIncidencia = tipoIncidencia_comboBox.SelectedItem.ToString();
                string fechaIncidencia = fechaInicio_date.Value.ToString();
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

                    if (localizacion.address != null)
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

                    int sourceId = buscarSourceId(cityTown, province);


                    Incidencia incidenciaModificar = new Incidencia(sourceId, tipoIncidencia, province, causaIncidencia, cityTown, fechaIncidencia, road, latitud, longitud, true);

                    incidenciaModificar.incidenceId = incidenceIdSeleccionada;

                    bool incidenciaModificada = await PatchJSON.modificarIncidencia(incidenciaModificar);

                    if (incidenciaModificada)
                    {
                        rellenarTabla();
                        reiniciarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la incidencia.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Necesitas seleccionar una incidencia de la tabla.");
            }
            
        }

        /**
         * Esta funcion se encarga de elegir el source ID de cada incidencia
         */

        private int buscarSourceId(string cityTown, string province)
        {
            if (cityTown.Equals("Donostia",StringComparison.OrdinalIgnoreCase))
            {
                return 7;
            }
            else if (cityTown.Equals("Vitoria", StringComparison.OrdinalIgnoreCase))
            {
                return 6;
            }
            else if (cityTown.Equals("Bilbao", StringComparison.OrdinalIgnoreCase))
            {
                return 5;
            }
            else if (province.Equals("Gipuzkoa", StringComparison.OrdinalIgnoreCase))
            {
                return 4;
            }
            else if (province.Equals("Araba/Álava", StringComparison.OrdinalIgnoreCase) || province.Equals("Araba", StringComparison.OrdinalIgnoreCase))
            {
                return 3;
            }
            else if (province.Equals("Bizkaia", StringComparison.OrdinalIgnoreCase))
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

    }

    
}
