namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            PHIEUNHAPKHOes = new HashSet<PHIEUNHAPKHO>();
        }

        [Key]
        [StringLength(6)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(32)]
        public string TenSP { get; set; }

        public byte[] AnhSP { get; set; }

        public int SoLuongTon { get; set; }

        [Required]
        [StringLength(3)]
        public string Size { get; set; }

        public decimal GiaNhap { get; set; }

        public decimal GiaBan { get; set; }

        [StringLength(32)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(6)]
        public string MaDM { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(6)]
        public string MaMau { get; set; }

        [Required]
        [StringLength(6)]
        public string MaCL { get; set; }

        [Required]
        [StringLength(6)]
        public string MaTH { get; set; }

        public virtual CHATLIEU CHATLIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        public virtual DANHMUC DANHMUC { get; set; }

        public virtual MAU MAU { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPKHO> PHIEUNHAPKHOes { get; set; }

        public virtual THUONGHIEU THUONGHIEU { get; set; }
    }
}
