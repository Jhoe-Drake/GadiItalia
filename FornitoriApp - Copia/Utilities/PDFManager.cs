using Microsoft.Extensions.Logging;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Utilities
{
    public class PDFManager
    {
        
        public static void GeneratePdf(string destinationPath)
        {
            try
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "PDF - PdfSharp Native";

                // 2. Add a page
                PdfPage page = document.AddPage();

                // 3. Create graphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);



                double leftMargin = 50;
                double topMargin = 50;
                double lineHeight = 20;

                // 11. Save the document
                document.Save(destinationPath);
                document.Close();
            }
            catch(Exception ex)  
            { }
        }
        
        public static void GeneratePreview(PdfDocument document, string destPath)
        {
            try
            {

                document.Save(destPath);
                document.Close();
            }
            catch (Exception ex) 
            { }
        }

        public static void PrintPDfDocument(string documentToPrint)
        {
            try
            {
                ProcessStartInfo printProcessInfo = new ProcessStartInfo
                {
                    Verb = "print",
                    FileName = documentToPrint,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process process = new Process();
                process.StartInfo = printProcessInfo;

                // Avvia il processo di stampa
                process.Start();
            }
            catch (Exception ex) 
            { 
            }
        }
    }
}
