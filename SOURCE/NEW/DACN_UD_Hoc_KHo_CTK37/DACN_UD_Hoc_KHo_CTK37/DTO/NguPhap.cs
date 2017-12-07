namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguPhap")]
    public partial class NguPhap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public int? IDDanhMucCon { get; set; }

        public virtual DanhMucCon DanhMucCon { get; set; }
    }
}
