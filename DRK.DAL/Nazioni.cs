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
    
    public partial class Nazioni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nazioni()
        {
            this.Clienti = new HashSet<Clienti>();
            this.Destinazioni = new HashSet<Destinazioni>();
            this.Regioni = new HashSet<Regioni>();
        }
    
        public short NazioneId { get; set; }
        public string NomeNazione { get; set; }
        public string CodiceOldGO { get; set; }
        public short CodiceLingua { get; set; }
        public short CodiceValuta { get; set; }
        public string CodiceISONazione { get; set; }
        public string CodiceBancaClienteStd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clienti> Clienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Destinazioni> Destinazioni { get; set; }
        public virtual Lingue Lingue { get; set; }
        public virtual Valute Valute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Regioni> Regioni { get; set; }
    }
}
