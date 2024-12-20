namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHATLIEU")]
    public partial class CHATLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHATLIEU()
        {
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        [StringLength(6)]
        public string MaCL { get; set; }

        [Required]
        [StringLength(32)]
        public string TenCL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
