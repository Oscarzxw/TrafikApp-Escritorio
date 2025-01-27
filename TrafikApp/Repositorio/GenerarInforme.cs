using Aspose.Pdf.Text;
using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;
using System.Drawing;
using System.Diagnostics;
using System.Collections;

namespace TrafikApp.Repositorio
{
    internal class GenerarInforme
    {

        public static void generarInforme(List<Incidencia> incidencias, string nombreArchivo)
        {
            // Crear un nuevo documento PDF
            Document document = new Document();

            // Crear una página dentro del documento
            Page page = document.Pages.Add();

            // Agregar título al documento
            TextFragment title = new TextFragment("Reporte de Incidencias");
            title.TextState.FontSize = 18;
            title.TextState.Font = FontRepository.FindFont("Arial");

            page.Paragraphs.Add(title);

            // Espaciado
            page.Paragraphs.Add(new TextFragment("\n"));

            // Crear una tabla en la página
            Table table = new Table
            {
                ColumnWidths = "50 150 300", // Establecer el ancho de las columnas
                DefaultCellPadding = new MarginInfo(5, 5, 5, 5), // Padding de las celdas
                Border = new BorderInfo(BorderSide.All, 0.5f) // Configuración del borde
            };

            // Agregar el encabezado de la tabla
            Row headerRow = table.Rows.Add();
            headerRow.Cells.Add("ID");
            headerRow.Cells.Add("Fecha");
            headerRow.Cells.Add("Descripción");

            // Llenar la tabla con las incidencias
            foreach (var incidencia in incidencias)
            {
                Row row = table.Rows.Add();
                row.Cells.Add(incidencia.incidenceId.ToString());
                row.Cells.Add(incidencia.startDate);
                row.Cells.Add(incidencia.cause);

                row.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.Red;
            }

            // Agregar la tabla a la página
            page.Paragraphs.Add(table);

            // Guardar el documento en el archivo de salida
            document.Save(nombreArchivo);

            AbrirPDF(nombreArchivo);
        }

        // Función para abrir el PDF usando el visor predeterminado del sistema
        private static void AbrirPDF(string rutaPDF)
        {
            try
            {
                // Usar el visor de PDF predeterminado del sistema para abrir el archivo generado
                Process.Start(new ProcessStartInfo(rutaPDF) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar abrir el archivo PDF: " + ex.Message);
            }
        }

    }
}
