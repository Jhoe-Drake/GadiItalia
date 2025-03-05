using Drk.Core.Data;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class PersonaDto: Dto
    {
        #region fields
        private string _name;
        private string _lastname;
        private string _descr;
        #endregion

        #region properties
        public string Name { get => _name; set => _name = value; }
        public string Cognome { get => _lastname; set => _lastname = value; }       
        public string Description { get => _descr; set => _descr = value;  }
        #endregion

        #region constructors
        public PersonaDto()
        { }
        public PersonaDto(int id) : this()
        { 
            _id = id;
        }
        #endregion
    }
}
