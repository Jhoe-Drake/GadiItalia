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
    
    public partial class FattureFornitori
    {
        public string FornitoreAdHocID { get; set; }
        public string FatturaFornitoreID { get; set; }
        public string RigaFatturaID { get; set; }
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public System.DateTime Data { get; set; }
        public double Importo { get; set; }
        public Nullable<int> FornitoreID { get; set; }
        public string NomeFornitoreAdHoc { get; set; }
        public string PercorsoFile { get; set; }
        public string NumFatturaFornitore { get; set; }
        public System.DateTime DataUltimaModifica { get; set; }
        public string Note { get; set; }
        public string FornitoriCollegati { get; set; }
        public Nullable<short> Stato { get; set; }
    
        public virtual Fornitori Fornitori { get; set; }
        public virtual Pratiche Pratiche { get; set; }
    }
}
