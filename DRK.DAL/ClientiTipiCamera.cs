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
    
    public partial class ClientiTipiCamera
    {
        public int ClienteID { get; set; }
        public string CodTipoCamera { get; set; }
        public Nullable<short> QtaStd { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        public virtual TipiCamera TipiCamera { get; set; }
    }
}
