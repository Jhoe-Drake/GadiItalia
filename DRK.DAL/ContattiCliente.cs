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
    
    public partial class ContattiCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContattiCliente()
        {
            this.Pratiche = new HashSet<Pratiche>();
            this.Pratiche1 = new HashSet<Pratiche>();
            this.Pratiche2 = new HashSet<Pratiche>();
        }
    
        public int ClienteID { get; set; }
        public short ContattoClienteID { get; set; }
        public string Tipo { get; set; }
        public string Titolo { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Descrizione { get; set; }
        public string Ruolo { get; set; }
        public string Telefono { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public string SkypeID { get; set; }
        public bool IsResponsabileDefault { get; set; }
        public bool IsResponsabileContabile { get; set; }
        public bool IsDestinatarioMailing { get; set; }
        public bool IsConsenzienteGDPR { get; set; }
        public Nullable<System.DateTime> DataConsensoGDPR { get; set; }
        public bool IsAttivo { get; set; }
        public bool IsPreferito { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche2 { get; set; }
    }
}
