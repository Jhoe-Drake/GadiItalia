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
    
    public partial class UsiDocumento
    {
        public int DocumentoID { get; set; }
        public short UsoDocumentoID { get; set; }
        public Nullable<int> DestinazioneID { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> FornitoreID { get; set; }
        public Nullable<int> ServizioID { get; set; }
        public Nullable<int> AnnoPratica { get; set; }
        public Nullable<int> NumPratica { get; set; }
        public Nullable<short> NumOfferta { get; set; }
        public Nullable<short> NumSezione { get; set; }
        public Nullable<short> ElementoOffertaID { get; set; }
        public Nullable<short> ElementoOrdineID { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        public virtual Destinazioni Destinazioni { get; set; }
        public virtual Fornitori Fornitori { get; set; }
        public virtual Offerte Offerte { get; set; }
        public virtual Pratiche Pratiche { get; set; }
        public virtual Servizi Servizi { get; set; }
    }
}
