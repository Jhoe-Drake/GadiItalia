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
    
    public partial class Cataloghi
    {
        public short CatalogoID { get; set; }
        public string Titolo { get; set; }
        public int AnnoRiferimento { get; set; }
        public string Formati { get; set; }
        public Nullable<System.DateTime> DataPubblicazione { get; set; }
        public Nullable<short> IdLingua { get; set; }
    }
}
