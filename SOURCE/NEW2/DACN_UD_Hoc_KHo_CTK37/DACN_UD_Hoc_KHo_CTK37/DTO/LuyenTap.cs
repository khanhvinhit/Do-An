namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuyenTap")]
    public partial class LuyenTap
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string HoiKHo { get; set; }

        [StringLength(250)]
        public string HoiViet { get; set; }

        [Column(TypeName = "ntext")]
        public string TraLoiKHo { get; set; }

        public int? IDDanhMucCon { get; set; }

        public virtual DanhMucCon DanhMucCon { get; set; }
    }
}
