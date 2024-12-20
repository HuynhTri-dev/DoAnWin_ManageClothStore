namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            DonHangs = new HashSet<DonHang>();
            KHUYENMAIs = new HashSet<KHUYENMAI>();
        }

        [Key]
        [StringLength(6)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(16)]
        public string Ho { get; set; }

        [Required]
        [StringLength(128)]
        public string TenLot { get; set; }

        public bool GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        [StringLength(256)]
        public string DiaChi { get; set; }

        [StringLength(256)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHUYENMAI> KHUYENMAIs { get; set; }
    }
}
