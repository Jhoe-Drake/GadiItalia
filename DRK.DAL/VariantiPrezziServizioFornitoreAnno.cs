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
    
    public partial class VariantiPrezziServizioFornitoreAnno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VariantiPrezziServizioFornitoreAnno()
        {
            this.ElementiOfferta = new HashSet<ElementiOfferta>();
            this.ElementiOrdine = new HashSet<ElementiOrdine>();
            this.UsiStringa = new HashSet<UsiStringa>();
        }
    
        public int ServizioID { get; set; }
        public int FornitoreID { get; set; }
        public int Anno { get; set; }
        public short VariantePrezzoID { get; set; }
        public Nullable<double> PrezzoAcquistoLordo { get; set; }
        public Nullable<double> PrezzoAcquistoScorporatoIva { get; set; }
        public Nullable<double> PrezzoVendita { get; set; }
        public string CondizioniDescrittive { get; set; }
        public Nullable<System.DateTime> DataDa { get; set; }
        public Nullable<System.DateTime> DataA { get; set; }
        public Nullable<short> PaxDa { get; set; }
        public Nullable<short> PaxA { get; set; }
        public string TipoPrezzoAcquisto { get; set; }
        public string TipoPrezzoVendita { get; set; }
        public Nullable<short> PaxLimite { get; set; }
        public Nullable<double> IncrementoUnitarioAcquisto { get; set; }
        public Nullable<double> IncrementoUnitarioVendita { get; set; }
        public Nullable<short> DivisoreAcquisto { get; set; }
        public Nullable<short> DivisoreVendita { get; set; }
        public Nullable<short> AliquotaIva { get; set; }
        public Nullable<double> PercCommissione { get; set; }
        public Nullable<short> AliquotaIvaSuCommissione { get; set; }
        public Nullable<double> CommissioneInEuroLorda { get; set; }
        public Nullable<long> NoteVoucherCliente { get; set; }
        public Nullable<long> NoteVoucherFornitore { get; set; }
        public bool IsDefault { get; set; }
        public Nullable<double> MargineLordo { get; set; }
        public Nullable<int> IDPrezzoGO4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOfferta> ElementiOfferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOrdine> ElementiOrdine { get; set; }
        public virtual Iva Iva { get; set; }
        public virtual Iva Iva1 { get; set; }
        public virtual ServiziFornitoriAnno ServiziFornitoriAnno { get; set; }
        public virtual Stringhe Stringhe { get; set; }
        public virtual Stringhe Stringhe1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsiStringa> UsiStringa { get; set; }
    }
}
