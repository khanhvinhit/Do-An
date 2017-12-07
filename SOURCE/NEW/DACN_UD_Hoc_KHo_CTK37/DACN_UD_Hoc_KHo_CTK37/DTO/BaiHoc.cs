namespace DACN_UD_Hoc_KHo_CTK37.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiHoc")]
    public partial class BaiHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiHoc()
        {
            DanhMucs = new HashSet<DanhMuc>();
            LoiHayYDeps = new HashSet<LoiHayYDep>();
        }

        public int ID { get; set; }

        [StringLength(250)]
        public string TenKHo { get; set; }

        [Column(TypeName = "ntext")]
        public string TenViet { get; set; }

        public int? IDHinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMuc> DanhMucs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoiHayYDep> LoiHayYDeps { get; set; }
    }
}
