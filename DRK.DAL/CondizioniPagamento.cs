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
    
    public partial class CondizioniPagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CondizioniPagamento()
        {
            this.ClientiCondizioniPagamento = new HashSet<ClientiCondizioniPagamento>();
            this.FornitoriCondizioniPagamento = new HashSet<FornitoriCondizioniPagamento>();
            this.CondizioniPagamentoCliente = new HashSet<CondizioniPagamentoCliente>();
            this.PratichePagamentiCliente = new HashSet<PratichePagamentiCliente>();
            this.PratichePagamentiFornitori = new HashSet<PratichePagamentiFornitori>();
        }
    
        public short TipoPagamentoID { get; set; }
        public long NomeTipoPagamento { get; set; }
        public bool FlagAcconto { get; set; }
        public Nullable<short> Perc { get; set; }
        public Nullable<short> CodEvento { get; set; }
        public Nullable<short> Giorni { get; set; }
        public bool FlagGiorniPrima { get; set; }
        public Nullable<short> CodMezzoPagamento { get; set; }
        public string NomeTipoPagamentoInterno { get; set; }
        public string CodPagamentoOld { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientiCondizioniPagamento> ClientiCondizioniPagamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FornitoriCondizioniPagamento> FornitoriCondizioniPagamento { get; set; }
        public virtual Eventi Eventi { get; set; }
        public virtual MezziPagamento MezziPagamento { get; set; }
        public virtual Stringhe Stringhe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondizioniPagamentoCliente> CondizioniPagamentoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PratichePagamentiCliente> PratichePagamentiCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PratichePagamentiFornitori> PratichePagamentiFornitori { get; set; }
    }
}
