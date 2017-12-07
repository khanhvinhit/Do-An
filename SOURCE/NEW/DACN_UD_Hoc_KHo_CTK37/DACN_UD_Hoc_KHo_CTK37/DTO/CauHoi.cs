namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHoi")]
    public partial class CauHoi
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Hoi { get; set; }

        [Column(TypeName = "ntext")]
        public string GoiY { get; set; }

        [Column(TypeName = "ntext")]
        public string TraLoi { get; set; }

        public int? IDDanhMucCon { get; set; }

        public virtual DanhMucCon DanhMucCon { get; set; }
    }
}
