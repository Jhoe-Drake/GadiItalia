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
    
    public partial class OrdiniTotaliSezioni
    {
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public short NumTotale { get; set; }
        public short NumSezione { get; set; }
    
        public virtual OrdiniTotali OrdiniTotali { get; set; }
        public virtual SezioniOrdine SezioniOrdine { get; set; }
    }
}
