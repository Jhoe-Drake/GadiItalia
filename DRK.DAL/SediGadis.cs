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
    
    public partial class SediGadis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SediGadis()
        {
            this.Operatori = new HashSet<Operatori>();
        }
    
        public short SedeID { get; set; }
        public string Codice { get; set; }
        public string Nome { get; set; }
        public string TelefoniFissi { get; set; }
        public string TelefoniMobili { get; set; }
        public string Luogo { get; set; }
        public Nullable<long> SalutiIniziali { get; set; }
        public Nullable<long> TestoInoltroCorrispondenza { get; set; }
        public bool UtilizzoIntestazione { get; set; }
        public string Indirizzo { get; set; }
        public string CodicePostale { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operatori> Operatori { get; set; }
        public virtual Stringhe Stringhe { get; set; }
        public virtual Stringhe Stringhe1 { get; set; }
    }
}
