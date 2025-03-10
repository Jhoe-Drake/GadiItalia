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
    
    public partial class Lingue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lingue()
        {
            this.Clienti = new HashSet<Clienti>();
            this.StringheLingue = new HashSet<StringheLingue>();
            this.Nazioni = new HashSet<Nazioni>();
            this.TipiDocumentoModelli = new HashSet<TipiDocumentoModelli>();
            this.Valute = new HashSet<Valute>();
            this.Fornitori = new HashSet<Fornitori>();
        }
    
        public short IdLingua { get; set; }
        public string Descrizione { get; set; }
        public string DescrizioneLingua { get; set; }
        public string DescrizioneCorta { get; set; }
        public string CodiceWEB { get; set; }
        public string CodiceIsoLingua { get; set; }
        public bool FlagAttiva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clienti> Clienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StringheLingue> StringheLingue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nazioni> Nazioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipiDocumentoModelli> TipiDocumentoModelli { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Valute> Valute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fornitori> Fornitori { get; set; }
    }
}
