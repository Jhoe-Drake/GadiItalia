using Drk.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class ContactDto:Dto
    {
        public string Tipo { get; set; }
        public string Titolo { get; set; }
        public PersonaDto Riferimento { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ContactDto() { }
        public ContactDto(int id) : this()
        {
            _id = id;
        }
    }
}
