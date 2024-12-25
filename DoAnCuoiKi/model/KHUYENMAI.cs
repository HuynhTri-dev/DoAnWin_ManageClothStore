namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(6)]
        public string MaKM { get; set; }

        [Required]
        [StringLength(16)]
        public string TenKM { get; set; }

        public double GiaTri { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayBatDau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayKetThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
