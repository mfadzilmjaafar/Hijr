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
    
    public partial class DokumenTravel
    {
        public string NoIC { get; set; }
        public string NoPasport { get; set; }
        public string NoVisa { get; set; }
    
        public virtual CIF CIF { get; set; }
    }
}
