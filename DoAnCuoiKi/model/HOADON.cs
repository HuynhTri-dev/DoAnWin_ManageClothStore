namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [StringLength(6)]
        public string MaHD { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal TongTien { get; set; }

        [Required]
        [StringLength(32)]
        public string PhuongThucThanhToan { get; set; }

        [StringLength(256)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(6)]
        public string MaDH { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
