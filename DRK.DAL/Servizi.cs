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
    
    public partial class Servizi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servizi()
        {
            this.Documenti = new HashSet<Documenti>();
            this.ElementiOfferta = new HashSet<ElementiOfferta>();
            this.ElementiOrdine = new HashSet<ElementiOrdine>();
            this.Lamentele = new HashSet<Lamentele>();
            this.OffertePubbliche = new HashSet<OffertePubbliche>();
            this.ServiziFornitoriAnno = new HashSet<ServiziFornitoriAnno>();
            this.UsiDocumento = new HashSet<UsiDocumento>();
            this.UsiImmagine = new HashSet<UsiImmagine>();
            this.UsiStringa = new HashSet<UsiStringa>();
            this.VariantiLogisticheServizio = new HashSet<VariantiLogisticheServizio>();
            this.Servizi1 = new HashSet<Servizi>();
            this.Servizi2 = new HashSet<Servizi>();
            this.SegmentiMarketing = new HashSet<SegmentiMarketing>();
        }
    
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
        public Nullable<short> NumPraticheAssociate { get; set; }
    
        public virtual CaratteristicheServizio CaratteristicheServizio { get; set; }
        public virtual Destinazioni Destinazioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documenti> Documenti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOfferta> ElementiOfferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOrdine> ElementiOrdine { get; set; }
        public virtual Fornitori Fornitori { get; set; }
        public virtual Fornitori Fornitori1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lamentele> Lamentele { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OffertePubbliche> OffertePubbliche { get; set; }
        public virtual Operatori Operatori { get; set; }
        public virtual Stringhe Stringhe { get; set; }
        public virtual Stringhe Stringhe1 { get; set; }
        public virtual Stringhe Stringhe2 { get; set; }
        public virtual Stringhe Stringhe3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiziFornitoriAnno> ServiziFornitoriAnno { get; set; }
        public virtual TipiServizio TipiServizio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsiDocumento> UsiDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsiImmagine> UsiImmagine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsiStringa> UsiStringa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VariantiLogisticheServizio> VariantiLogisticheServizio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi> Servizi1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi> Servizi2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SegmentiMarketing> SegmentiMarketing { get; set; }
    }
}
