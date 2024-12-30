namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPKHO")]
    public partial class PHIEUNHAPKHO
    {
        [Key]
        public int MaPhieu { get; set; }

        [Required]
        [StringLength(6)]
        public string MaSP { get; set; }

        public int SoLuongNhap { get; set; }

        public DateTime NgayNhap { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
