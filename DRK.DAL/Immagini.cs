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
    
    public partial class Immagini
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Immagini()
        {
            this.UsiImmagine = new HashSet<UsiImmagine>();
        }
    
        public int ImmagineID { get; set; }
        public string NomeFile { get; set; }
        public string Tipo { get; set; }
        public string DimensioneinKb { get; set; }
        public string Titolo { get; set; }
        public string Tags { get; set; }
        public string Copyright { get; set; }
        public string Fonte { get; set; }
        public Nullable<System.DateTime> DataInserimento { get; set; }
        public string Metadati { get; set; }
        public string Percorso { get; set; }
        public byte[] Thumbnail { get; set; }
        public Nullable<int> DimX { get; set; }
        public Nullable<int> DimY { get; set; }
        public Nullable<short> CollezioneID { get; set; }
    
        public virtual CollezioniImmagini CollezioniImmagini { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsiImmagine> UsiImmagine { get; set; }
    }
}
