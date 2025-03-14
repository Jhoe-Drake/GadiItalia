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
    
    public partial class Z_Sincro_GO4_Fornitori_SchedePrezzi_VariantiPrezzi_DaInserire
    {
        public int ServizioID { get; set; }
        public int FornitoreID { get; set; }
        public int Anno { get; set; }
        public Nullable<long> VariantePrezzo { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> PrezzoLordo { get; set; }
        public Nullable<int> AliquotaIVA { get; set; }
        public Nullable<decimal> ImportoScorporatoIVA { get; set; }
        public Nullable<float> PercentualeCommissione { get; set; }
        public Nullable<decimal> CommissioneCalcolata { get; set; }
        public Nullable<decimal> CommissioneManuale { get; set; }
        public Nullable<int> AliquotaCommissione { get; set; }
        public Nullable<decimal> IVAsuCommissione { get; set; }
        public Nullable<decimal> PrezzoNettoAcquisto { get; set; }
        public Nullable<decimal> PrezzoVendita { get; set; }
        public string ServizioCodiceVecchio { get; set; }
        public string ServizioDescrizioneVecchio { get; set; }
        public string ServizioCodiceAggiornato { get; set; }
        public string NoteVoucherFornitore { get; set; }
        public Nullable<short> ApplicazioneAcquisto { get; set; }
        public Nullable<short> LegameAcquisto { get; set; }
        public Nullable<float> DivisoreAcquisto { get; set; }
        public Nullable<short> ApplicazioneVendita { get; set; }
        public Nullable<short> LegameVendita { get; set; }
        public Nullable<float> DivisoreVendita { get; set; }
        public string CodicePrezzoVecchio { get; set; }
        public Nullable<System.DateTime> DataLavoro { get; set; }
        public string Operatore { get; set; }
        public string Localita { get; set; }
        public Nullable<int> QuantitaDa { get; set; }
        public Nullable<int> QuantitaA { get; set; }
        public Nullable<System.DateTime> DataValidaDa { get; set; }
        public Nullable<System.DateTime> DataValidaA { get; set; }
        public Nullable<int> CodicePrezzoSuccessivo { get; set; }
        public Nullable<decimal> PrezzoLordoIncremento { get; set; }
        public Nullable<decimal> PrezzoVenditaIncremento { get; set; }
        public string NoteOrdine { get; set; }
        public string NoteInterne { get; set; }
    }
}
