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
    
    public partial class FeedbackCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeedbackCliente()
        {
            this.FeedbackClienteServizi = new HashSet<FeedbackClienteServizi>();
        }
    
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public Nullable<System.DateTime> DataRichiestaFeedback { get; set; }
        public Nullable<System.DateTime> DataArrivoFeedback { get; set; }
        public string AutoreFeedback { get; set; }
        public bool FlagWeb { get; set; }
        public string OperatoreGadisID { get; set; }
        public Nullable<int> DocumentoID { get; set; }
        public Nullable<short> FeedbackGestionePratica { get; set; }
        public Nullable<short> FeedbackSupportoAlViaggio { get; set; }
        public string CommentiCliente { get; set; }
    
        public virtual Documenti Documenti { get; set; }
        public virtual Pratiche Pratiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackClienteServizi> FeedbackClienteServizi { get; set; }
    }
}
