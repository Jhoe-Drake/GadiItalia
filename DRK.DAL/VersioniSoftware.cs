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
    
    public partial class VersioniSoftware
    {
        public int VersioneID { get; set; }
        public bool FlagAttiva { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }
        public int MajorCompatibile { get; set; }
        public int MinorCompatibile { get; set; }
        public int BuildCompatibile { get; set; }
        public int RevisionCompatibile { get; set; }
    }
}
