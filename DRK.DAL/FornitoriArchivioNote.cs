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
    
    public partial class FornitoriArchivioNote
    {
        public int FornitoreID { get; set; }
        public string NoteContabili { get; set; }
        public string NotePerPratica { get; set; }
        public string NoteInterne { get; set; }
        public Nullable<System.DateTime> DataUltAgg { get; set; }
    
        public virtual Fornitori Fornitori { get; set; }
    }
}
