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
    
    public partial class Eventi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eventi()
        {
            this.ClientiCondizioniPagamento = new HashSet<ClientiCondizioniPagamento>();
            this.CondizioniPagamento = new HashSet<CondizioniPagamento>();
            this.FornitoriCondizioniPagamento = new HashSet<FornitoriCondizioniPagamento>();
            this.PratichePagamentiCliente = new HashSet<PratichePagamentiCliente>();
            this.PratichePagamentiFornitori = new HashSet<PratichePagamentiFornitori>();
        }
    
        public short CodEvento { get; set; }
        public string NomeEvento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientiCondizioniPagamento> ClientiCondizioniPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondizioniPagamento> CondizioniPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FornitoriCondizioniPagamento> FornitoriCondizioniPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PratichePagamentiCliente> PratichePagamentiCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PratichePagamentiFornitori> PratichePagamentiFornitori { get; set; }
    }
}
