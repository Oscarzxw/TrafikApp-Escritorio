using Aspose.Pdf.Text;
using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using TrafikApp.Model;
using System.Linq;

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
                ColumnWidths = "50 150 50 300",
                DefaultCellPadding = new MarginInfo(5, 5, 5, 5),
                Border = new BorderInfo(BorderSide.All, 0.5f)
            };

            Row headerRow = table.Rows.Add();
            headerRow.Cells.Add("ID");
            headerRow.Cells.Add("Fecha");
            headerRow.Cells.Add("Tipo");
            headerRow.Cells.Add("Descripción");

            foreach (var incidencia in incidencias)
            {
                Row row = table.Rows.Add();
                row.Cells.Add(incidencia.incidenceId.ToString());
                row.Cells.Add(incidencia.startDate);
                row.Cells.Add(incidencia.incidenceType);
                row.Cells.Add(incidencia.cause);

                if (incidencia.incidenceType.Equals("EVEN", StringComparison.OrdinalIgnoreCase))
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
                        else
                        {
                            if (incidencia.incidenceType.Equals("ACCIDENTE", StringComparison.OrdinalIgnoreCase))
                            {
                                row.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.Red;
                            }
                            else
                            {
                                if (incidencia.incidenceType.Equals("CALLE CORTADA", StringComparison.OrdinalIgnoreCase))
                                {
                                    row.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.DarkGreen;
                                }
                            }
                        }
                    }
                }

            }

            page.Paragraphs.Add(table);
            page.Paragraphs.Add(new TextFragment("\n\n"));

            string imagePath = "grafico.png";
            GenerarGraficoTartaConLeyenda(incidencias, imagePath);

            Aspose.Pdf.Image pdfImage = new Aspose.Pdf.Image();
            pdfImage.File = imagePath;
            page.Paragraphs.Add(pdfImage);

            document.Save(nombreArchivo);

            AbrirPDF(nombreArchivo);
        }

        private static void GenerarGraficoTartaConLeyenda(List<Incidencia> incidencias, string filePath)
        {
            int evenCount = incidencias.Count(i => i.incidenceType.Equals("EVEN", StringComparison.OrdinalIgnoreCase));
            int obraCount = incidencias.Count(i => i.incidenceType.Equals("OBRA", StringComparison.OrdinalIgnoreCase));
            int accidenteCount = incidencias.Count(i => i.incidenceType.Equals("ACCIDENTE", StringComparison.OrdinalIgnoreCase));
            int calleCount = incidencias.Count(i => i.incidenceType.Equals("CALLE CORTADA", StringComparison.OrdinalIgnoreCase));
            int otroCount = incidencias.Count(i => i.incidenceType.Equals("OTRO", StringComparison.OrdinalIgnoreCase));

            int total = evenCount + obraCount + accidenteCount + calleCount + otroCount;
            if (total == 0) return;

            using (Bitmap bitmap = new Bitmap(500, 400))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(System.Drawing.Color.White);

                float startAngle = 0;
                float sweepEven = (evenCount / (float)total) * 360;
                float sweepObra = (obraCount / (float)total) * 360;
                float sweepAccidente = (accidenteCount / (float)total) * 360;
                float sweepCalle = (calleCount / (float)total) * 360;
                float sweepOtro = (otroCount / (float)total) * 360;

                System.Drawing.Color colorEven = System.Drawing.Color.Blue;
                System.Drawing.Color colorObra = System.Drawing.Color.Cyan;
                System.Drawing.Color colorAccidente = System.Drawing.Color.Red;
                System.Drawing.Color colorCalle = System.Drawing.Color.Green;
                System.Drawing.Color colorOtro = System.Drawing.Color.Gray;

                using (Brush brushEven = new SolidBrush(colorEven))
                using (Brush brushObra = new SolidBrush(colorObra))
                using (Brush brushAccidente = new SolidBrush(colorAccidente))
                using (Brush brushCalle = new SolidBrush(colorCalle))
                using (Brush brushOtro = new SolidBrush(colorOtro))
                {
                    g.FillPie(brushEven, 50, 50, 300, 300, startAngle, sweepEven);
                    startAngle += sweepEven;
                    g.FillPie(brushObra, 50, 50, 300, 300, startAngle, sweepObra);
                    startAngle += sweepObra;
                    g.FillPie(brushAccidente, 50, 50, 300, 300, startAngle, sweepAccidente);
                    startAngle += sweepAccidente;
                    g.FillPie(brushCalle, 50, 50, 300, 300, startAngle, sweepCalle);
                    startAngle += sweepCalle;
                    g.FillPie(brushOtro, 50, 50, 300, 300, startAngle, sweepOtro);
                }

                System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                Brush textBrush = Brushes.Black;
                int legendX = 380;
                int legendY = 100;
                int boxSize = 20; 

                DibujarLeyenda(g, "EVEN", colorEven, legendX, legendY, boxSize, font, textBrush);
                DibujarLeyenda(g, "OBRA", colorObra, legendX, legendY + 30, boxSize, font, textBrush);
                DibujarLeyenda(g, "ACCIDENTE", colorAccidente, legendX, legendY + 60, boxSize, font, textBrush);
                DibujarLeyenda(g, "CALLE CORTADA", colorCalle, legendX, legendY + 90, boxSize, font, textBrush);
                DibujarLeyenda(g, "OTRO", colorOtro, legendX, legendY + 120, boxSize, font, textBrush);

                bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private static void DibujarLeyenda(Graphics g, string texto, System.Drawing.Color color, int x, int y, int size, System.Drawing.Font font, Brush textBrush)
        {
            using (Brush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, x, y, size, size);
            }
            g.DrawRectangle(Pens.Black, x, y, size, size);
            g.DrawString(texto, font, textBrush, x + size + 5, y);
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
