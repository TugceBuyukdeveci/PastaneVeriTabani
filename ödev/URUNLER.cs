//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ödev
{
    using System;
    using System.Collections.Generic;
    
    public partial class URUNLER
    {
        public URUNLER()
        {
            this.SIPARISLER = new HashSet<SIPARISLER>();
            this.STOKLAR = new HashSet<STOKLAR>();
        }
    
        public int Urün_id { get; set; }
        public string Urun_Ad { get; set; }
    
        public virtual ICollection<SIPARISLER> SIPARISLER { get; set; }
        public virtual ICollection<STOKLAR> STOKLAR { get; set; }
    }
}
