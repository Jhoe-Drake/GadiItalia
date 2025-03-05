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
    
    public partial class RichForn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RichForn()
        {
            this.RichFornServizi = new HashSet<RichFornServizi>();
        }
    
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public short ProgPratica { get; set; }
        public int FornitoreID { get; set; }
        public System.DateTime DataRichiesta { get; set; }
        public Nullable<System.DateTime> DataRisposta { get; set; }
        public Nullable<long> MessaggioRichiestaID { get; set; }
        public Nullable<long> MessaggioRispostaID { get; set; }
        public string IsRispOK { get; set; }
        public string CanaleRispostaID { get; set; }
        public short TipoRichForn { get; set; }
    
        public virtual Fornitori Fornitori { get; set; }
        public virtual Messaggi Messaggi { get; set; }
        public virtual Messaggi Messaggi1 { get; set; }
        public virtual Pratiche Pratiche { get; set; }
        public virtual TipoRichForn TipoRichForn1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RichFornServizi> RichFornServizi { get; set; }
    }
}
