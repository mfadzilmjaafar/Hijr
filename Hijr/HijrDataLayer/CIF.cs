//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HijrDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CIF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIF()
        {
            this.CardStocks = new HashSet<CardStock>();
        }
    
        public string NoIC { get; set; }
        public string Nama { get; set; }
        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }
        public string Alamat3 { get; set; }
        public string Poskod { get; set; }
        public string Bandar { get; set; }
        public string KodNegeri { get; set; }
        public string NoTel { get; set; }
        public string PicPath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardStock> CardStocks { get; set; }
        public virtual DokumenTravel DokumenTravel { get; set; }
        public virtual Kesihatan Kesihatan { get; set; }
        public virtual Pergerakan Pergerakan { get; set; }
        public virtual RefNegeri RefNegeri { get; set; }
        public virtual Penempatan Penempatan { get; set; }
    }
}
