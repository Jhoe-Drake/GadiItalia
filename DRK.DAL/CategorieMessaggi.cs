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
    
    public partial class CategorieMessaggi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategorieMessaggi()
        {
            this.Messaggi = new HashSet<Messaggi>();
        }
    
        public short CategoriaMsgID { get; set; }
        public string NomeCategoriaMsg { get; set; }
        public string TipoCategoria { get; set; }
        public string InOut { get; set; }
        public string Descrizione { get; set; }
        public string Automatismo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messaggi> Messaggi { get; set; }
    }
}
