using Drk.Core.Data;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class AddressDto :Dto
    {
        #region fields
        private string _descr;
        private string _address;
        private string _city;
        
        private string _cap;
        private string _province;
        #endregion


        #region properties
        public string Indirizzo { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Provincia { get => _province; set => _province = value; }
        public string CAP { get => _cap; set => _cap = value; }
        public string Descrizione { get => _descr; set => _descr = value; }
        #endregion

        public AddressDto() { }
        public AddressDto(int id):this() 
        {
            _id = id;
        }
    }
}
