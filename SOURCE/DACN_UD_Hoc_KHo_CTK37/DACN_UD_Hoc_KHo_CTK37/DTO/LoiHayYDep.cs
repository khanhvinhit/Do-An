//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoiHayYDep
    {
        public int ID { get; set; }
        public string CauKHo { get; set; }
        public string CauViet { get; set; }
        public Nullable<int> IDBaiHoc { get; set; }
    
        public virtual BaiHoc BaiHoc { get; set; }
    }
}