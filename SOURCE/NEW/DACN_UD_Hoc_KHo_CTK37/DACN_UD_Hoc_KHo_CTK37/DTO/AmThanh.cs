namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AmThanh")]
    public partial class AmThanh
    {
        public int ID { get; set; }

        [Column(TypeName = "ntext")]
        public string DuongDan { get; set; }
    }
}
