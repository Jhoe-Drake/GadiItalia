


using FornitoriApp.Models;
using Scriban;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FornitoriApp.Utilities
{
    public class TemplateParser
    {
        public static string TemplatePath { get { return Path.Combine(Constants.ApplicationFolder, Constants.AssetsFolderName, Constants.TemplatesFolderName); } }
        
        public static string ParseTemplate(string templatePath, object tplModel)
        {
            string htmldocument = string.Empty;
            try
            {

                List<string> immaginilist = new List<string>();
                
                string tplStructure = File.ReadAllText(templatePath);
                
                var template = Template.Parse(tplStructure);
                htmldocument = template.Render(tplModel); // => "Hello World!" 

            }

            catch (Exception ex)
            {

                throw ex;
            }
            return htmldocument;
        }
    }
}
