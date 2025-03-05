using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class TemplateModelData<TDto>
    {
        public Dictionary<string, string> Labels { get; set; }
        public TDto ModelData { get; set; }
        public TemplateModelData() 
        { 
            Labels = new Dictionary<string, string>();

        }
    }
}
