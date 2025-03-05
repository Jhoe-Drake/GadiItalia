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
    
    public partial class Note
    {
        public long NotaID { get; set; }
        public string Testo { get; set; }
        public string Autore { get; set; }
        public Nullable<int> Cliente { get; set; }
        public Nullable<int> Destinazione { get; set; }
        public Nullable<int> Fornitore { get; set; }
        public bool IsLamentela { get; set; }
        public System.DateTime Timestamp { get; set; }
        public Nullable<int> AnnoPratica { get; set; }
        public Nullable<int> NumPratica { get; set; }
        public Nullable<int> ServizioID { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        public virtual Destinazioni Destinazioni { get; set; }
        public virtual Operatori Operatori { get; set; }
        public virtual Pratiche Pratiche { get; set; }
    }
}
