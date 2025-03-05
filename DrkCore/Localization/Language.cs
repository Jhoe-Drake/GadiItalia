using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Localization
{
    public enum Languages
    {
        [Description("Italiano")]
        It,
        [Description("English")]
        En,
        [Description("Deutsch")]
        De
    }
    public class Language
    {
        public string Description { get; set; }
        public string Culture { get; set; }
        public Languages Code { get; set; }
       
    }
}
