using Drk.Core.Localization;
using Drk.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Drk.Core.Utilities
{
    public class LanguagesUtilities
    {
       
        public static void ChangeLanguage(Languages newCulture)
        {
            switch (newCulture)
            {
                case Languages.It:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("it-IT"); 
                    break;

                case Languages.En:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
                    
                    break;
                case Languages.De:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("de-DE");
                    
                    break;
            }
        }

        public static Languages GetLanguage(string lang)
        { 
            var lan = Languages.It;
            switch(lang)
            {
                case "It":
                case "IT":
                case "it":
                    lan= Languages.It;
                    break;
                case "En":
                case "EN":
                case "en":
                    lan =  Languages.En;
                    break;
                case "De":
                case "DE":
                case "de":
                    lan =  Languages.De;
                    break;

                default: lan = Languages.It;
                    break;
            }
            return lan;
        }
        public static string GetCultureName(Languages lang)
        {
            string culture;
            switch (lang)
            { 
                case Languages.It:
                    culture = "it-IT";
                    break;
                case Languages.En:
                    culture = "en-US";
                    break;
                case Languages.De:
                    culture = "de-DE";
                    break;

                default:
                    culture = "it-IT";
                    break;

            }
            return culture;
        }

        public static String GetString(string key, ResourceManager resourceManager)
        {
            try
            {
                if (string.IsNullOrEmpty(key))
                    return string.Empty;

                
                var localized = resourceManager.GetString(key);
                return localized;
            }
            catch(Exception ex)
            {
                return "Text Not Found";
            }
        }
    }
}
