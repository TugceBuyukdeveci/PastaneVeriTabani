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
    
    public partial class STOKLAR
    {
        public int Stok_id { get; set; }
        public Nullable<int> Urün_id { get; set; }
        public Nullable<int> Alinanmal_id { get; set; }
    
        public virtual ALINANMALLAR ALINANMALLAR { get; set; }
        public virtual URUNLER URUNLER { get; set; }
    }
}
