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
    
    public partial class Servizi2
    {
        public int ServizioID { get; set; }
        public int FornitoreID { get; set; }
        public int TipoServizioID { get; set; }
        public int DestinazioneID { get; set; }
        public string NomeInternoServizio { get; set; }
        public long NomePubblicoServizio { get; set; }
        public Nullable<short> Giudizio { get; set; }
        public Nullable<long> DescrizioneEstesa { get; set; }
        public string LocalitaGO2 { get; set; }
        public Nullable<int> CodFornitorePreferenziale { get; set; }
        public Nullable<long> NoteVoucherCliente { get; set; }
        public Nullable<long> NoteVoucherFornitore { get; set; }
        public string NoteInterne { get; set; }
        public Nullable<short> DurataBaseServizioInOre { get; set; }
        public Nullable<short> LimiteMinPax { get; set; }
        public Nullable<short> LimiteMaxPax { get; set; }
        public Nullable<short> NumPostiPerMezzo { get; set; }
        public Nullable<System.TimeSpan> OrarioInizio { get; set; }
        public bool FlagAttivo { get; set; }
        public bool FlagRaggruppamento { get; set; }
        public string OperUltAgg { get; set; }
        public System.DateTime DataUltAgg { get; set; }
    
        public virtual Destinazioni Destinazioni { get; set; }
        public virtual Fornitori Fornitori { get; set; }
        public virtual Fornitori Fornitori1 { get; set; }
        public virtual Operatori Operatori { get; set; }
        public virtual Stringhe Stringhe { get; set; }
        public virtual Stringhe Stringhe1 { get; set; }
        public virtual Stringhe Stringhe2 { get; set; }
        public virtual Stringhe Stringhe3 { get; set; }
        public virtual TipiServizio TipiServizio { get; set; }
    }
}
