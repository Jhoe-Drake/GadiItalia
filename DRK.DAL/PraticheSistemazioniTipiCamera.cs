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
    
    public partial class PraticheSistemazioniTipiCamera
    {
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public System.DateTime DataAggiornamento { get; set; }
        public string CodTipoCamera { get; set; }
        public Nullable<short> Quantita { get; set; }
        public Nullable<System.DateTime> DataOpzioneFornitore { get; set; }
        public Nullable<System.DateTime> DataOpzioneCliente { get; set; }
        public Nullable<short> Arrivati { get; set; }
    
        public virtual PraticheSistemazioni PraticheSistemazioni { get; set; }
        public virtual TipiCamera TipiCamera { get; set; }
    }
}
