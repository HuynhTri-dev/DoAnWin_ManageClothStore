namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUGIAOHANG")]
    public partial class PHIEUGIAOHANG
    {
        [Key]
        [StringLength(6)]
        public string MaPhieu { get; set; }

        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(256)]
        public string DiaChi { get; set; }

        public DateTime NgayGiaoHang { get; set; }

        [Required]
        [StringLength(32)]
        public string TrangThaiGiaoHang { get; set; }

        [StringLength(256)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(6)]
        public string MaDH { get; set; }

        [Required]
        [StringLength(3)]
        public string MaPhi { get; set; }

        public virtual DONHANG DONHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIGIAOHANG PHIGIAOHANG { get; set; }
    }
}
