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
    
    public partial class DisponibilitaFornitore
    {
        public int FornitoreID { get; set; }
        public System.DateTime Da { get; set; }
        public Nullable<System.DateTime> A { get; set; }
        public Nullable<short> Camere { get; set; }
        public System.DateTime DataComunicazione { get; set; }
        public Nullable<System.DateTime> DataOpzioneGadis { get; set; }
        public string NoteInterne { get; set; }
    
        public virtual FornitoriValutazioni FornitoriValutazioni { get; set; }
    }
}
