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
    
    public partial class ServiziFornitoriAnno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiziFornitoriAnno()
        {
            this.VariantiPrezziServizioFornitoreAnno = new HashSet<VariantiPrezziServizioFornitoreAnno>();
        }
    
        public int ServizioID { get; set; }
        public int FornitoreID { get; set; }
        public int Anno { get; set; }
    
        public virtual Servizi Servizi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VariantiPrezziServizioFornitoreAnno> VariantiPrezziServizioFornitoreAnno { get; set; }
    }
}
