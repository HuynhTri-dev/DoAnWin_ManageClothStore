namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANG")]
    public partial class CHITIETDONHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MaDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MaSP { get; set; }

        public int SoLuong { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
