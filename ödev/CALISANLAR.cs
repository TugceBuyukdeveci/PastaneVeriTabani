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
    
    public partial class CALISANLAR
    {
        public CALISANLAR()
        {
            this.SIPARISLER = new HashSet<SIPARISLER>();
        }
    
        public int Calisan_id { get; set; }
        public string Calisan_Ad { get; set; }
        public string Calisan_Soyad { get; set; }
        public string Calisan_Cep_Tel { get; set; }
        public string Calisan_Mail { get; set; }
    
        public virtual ICollection<SIPARISLER> SIPARISLER { get; set; }
    }
}
