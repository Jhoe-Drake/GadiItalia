using Drk.Core.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class ImmagineDto:Dto
    {

        public string Nome { get; set; }
        public string BasePath { get; set; }
        public string FullPath { get => Path.Combine(BasePath, Nome); }
        public ImmagineDto() { }
        public ImmagineDto(int id):this() 
        {
            _id = id;
        }
    }
}
