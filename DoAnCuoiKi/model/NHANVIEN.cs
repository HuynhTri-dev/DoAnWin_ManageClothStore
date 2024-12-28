namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(6)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(16)]
        public string Ho { get; set; }

        [Required]
        [StringLength(128)]
        public string LotTen { get; set; }

        [Required]
        [StringLength(6)]
        public string ChucVu { get; set; }

        public bool GioiTinh { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [Required]
        [StringLength(6)]
        public string MaTK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
