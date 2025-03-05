using PdfSharp.Pdf;
using Scriban;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace FornitoriApp.Utilities
{
    public class TemplateParser
    {
        public static string TemplatePath { get { return Path.Combine(Constants.ApplicationFolder, Constants.AssetsFolderName, Constants.TemplatesFolderName); } }
        public static PdfDocument ParseTemplate<T>(string templatePath, T modelData)
        {
            PdfDocument document = null;
            try
            {
                Template tpl = Template.Parse(templatePath);
                string result = tpl.Render(modelData);
                document = PdfGenerator.GeneratePdf(result, PdfSharp.PageSize.A4);
            }
            catch (Exception ex) 
            { 
            }
            return document;
        }
    }
}
