//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
	public partial class CauHoi
    {
        public int ID { get; set; }
        public string Hoi { get; set; }
        public string GoiY { get; set; }
        public string TraLoi { get; set; }
        public Nullable<int> IDDanhMucCon { get; set; }
    
        public virtual DanhMucCon DanhMucCon { get; set; }
    }
}
