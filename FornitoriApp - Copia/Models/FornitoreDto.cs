using Drk.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class FornitoreDto : Dto
    {
        #region fields
        private string _ragSoc;
        private string _nomeInternal;
        private PersonaDto _responsabile;
        private AddressDto _sedeLegale;
        private List<ActivityTypeDto> _activities;
        private List<AddressDto> _destinazioni;
        private List<string> _immagini;
        private bool _active;
        #endregion

        #region properties
        public string RagioneSociale { get => _ragSoc; set => _ragSoc = value; }
        public string NomeInterno { get => _nomeInternal; set => _nomeInternal = value; }
        public PersonaDto Responsabile { get => _responsabile; set => _responsabile = value; }
        public AddressDto SedeLegale { get => _sedeLegale; set => _sedeLegale = value; }
        public List<string> Immagini { get => _immagini; set => _immagini = value; }
        public bool IsActive { get => _active; set => _active = value;  }
        #endregion

        #region constructors
        public FornitoreDto() 
        {
            _activities = new List<ActivityTypeDto>();
            _destinazioni = new List<AddressDto>();
            _immagini= new List<string>();
        }
        public FornitoreDto(int id) :this()
        { 
            _id = id;
        }
        #endregion
    }
}
