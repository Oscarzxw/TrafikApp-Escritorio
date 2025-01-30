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
            Document document = new Document();

            Page page = document.Pages.Add();
            page.PageInfo.IsLandscape = true;

            TextFragment title = new TextFragment("Informe de Incidencias");
            title.TextState.FontSize = 20;
            title.TextState.Font = FontRepository.FindFont("Arial");

            page.Paragraphs.Add(title);

            page.Paragraphs.Add(new TextFragment("\n"));

            Table table = new Table
            {
                ColumnWidths = "50 150 300",
                DefaultCellPadding = new MarginInfo(5, 5, 5, 5),
                Border = new BorderInfo(BorderSide.All, 0.5f)
            };

            Row headerRow = table.Rows.Add();
            headerRow.Cells.Add("ID");
            headerRow.Cells.Add("Fecha");
            headerRow.Cells.Add("Descripción");

            foreach (var incidencia in incidencias)
            {
                Row row = table.Rows.Add();
                row.Cells.Add(incidencia.incidenceId.ToString());
                row.Cells.Add(incidencia.startDate);
                row.Cells.Add(incidencia.incidenceType);
                row.Cells.Add(incidencia.cause);

                if(incidencia.incidenceType.Equals("EVEN", StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.DarkBlue;
                }
                else
                {
                    if (incidencia.incidenceType.Equals("OBRA", StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.DarkCyan;
                    }
                    else
                    {
                        if (incidencia.incidenceType.Equals("OTRO", StringComparison.OrdinalIgnoreCase))
                        {
                            row.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.Black;
                        }
                    }
                }
                
            }

            page.Paragraphs.Add(table);

            document.Save(nombreArchivo);

            AbrirPDF(nombreArchivo);
        }

        private static void AbrirPDF(string rutaPDF)
        {
            try
            {
                Process.Start(new ProcessStartInfo(rutaPDF) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar abrir el archivo PDF: " + ex.Message);
            }
        }

    }
}
