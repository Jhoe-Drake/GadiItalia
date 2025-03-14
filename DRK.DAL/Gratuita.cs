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
    
    public partial class Gratuita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gratuita()
        {
            this.Clienti = new HashSet<Clienti>();
            this.ElementiOfferta = new HashSet<ElementiOfferta>();
            this.ElementiOrdine = new HashSet<ElementiOrdine>();
            this.Fornitori = new HashSet<Fornitori>();
            this.GratuitaCondizioni = new HashSet<GratuitaCondizioni>();
            this.Pratiche = new HashSet<Pratiche>();
            this.SezioniOfferta = new HashSet<SezioniOfferta>();
            this.SezioniOrdine = new HashSet<SezioniOrdine>();
            this.TipiServizio = new HashSet<TipiServizio>();
        }
    
        public string GratuitaID { get; set; }
        public string DescrizioneInterna { get; set; }
        public long DescrizioneInLingua { get; set; }
        public Nullable<short> NumLimitePersoneGratuitaGo2 { get; set; }
        public Nullable<short> NumGratuita { get; set; }
        public Nullable<short> NumGratuitaGo2 { get; set; }
        public Nullable<short> CondizioneGratuita { get; set; }
        public Nullable<short> FattoreGratuita { get; set; }
        public Nullable<short> LimiteGratuita { get; set; }
        public string PerGratuita { get; set; }
        public Nullable<short> Sistemazione { get; set; }
        public Nullable<short> Collegamento { get; set; }
        public string NotaInterna { get; set; }
        public string OperatoreID { get; set; }
        public string DescrizioneDerivata { get; set; }
        public bool IsCalcolabile { get; set; }
        public string TipoGratuita { get; set; }
        public Nullable<short> NumSeqGratuita { get; set; }
        public bool FlagPrioritaria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clienti> Clienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOfferta> ElementiOfferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOrdine> ElementiOrdine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fornitori> Fornitori { get; set; }
        public virtual Operatori Operatori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GratuitaCondizioni> GratuitaCondizioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SezioniOfferta> SezioniOfferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SezioniOrdine> SezioniOrdine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipiServizio> TipiServizio { get; set; }
    }
}
