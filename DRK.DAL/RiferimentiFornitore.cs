//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drk.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class RiferimentiFornitore
    {
        public int FornitoreID { get; set; }
        public short RiferimentoFornitoreID { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string DescrizioneRuolo { get; set; }
        public string EstremiIndirizzo { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool IsPreferito { get; set; }
    
        public virtual Fornitori Fornitori { get; set; }
    }
}
