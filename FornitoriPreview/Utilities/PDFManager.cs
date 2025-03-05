
using SelectPdf;
using System;
using System.Diagnostics;

namespace FornitoriApp.Utilities
{
    public class PDFManager
    {
        
        
        
        public static void GeneratePreview(string htmlDocument, string destPath)
        {
           
            try
            {
                string baseUrl = string.Empty;
                HtmlToPdf converter = new HtmlToPdf();

                // set converter options
                converter.Options.PdfPageSize = PdfPageSize.A4;
                converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
                converter.Options.WebPageWidth = 1024;
                converter.Options.WebPageHeight = 0;// auto detect;

                // create a new pdf document converting an url
                PdfDocument document = converter.ConvertHtmlString(htmlDocument, baseUrl);
                document.Save(destPath);
                document.Close();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

       
    }
}
