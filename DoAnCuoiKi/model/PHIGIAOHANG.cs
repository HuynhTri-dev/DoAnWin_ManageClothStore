namespace DoAnCuoiKi.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIGIAOHANG")]
    public partial class PHIGIAOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIGIAOHANG()
        {
            PHIEUGIAOHANGs = new HashSet<PHIEUGIAOHANG>();
        }

        [Key]
        [StringLength(3)]
        public string MaPhi { get; set; }

        [Required]
        [StringLength(16)]
        public string KhuVuc { get; set; }

        [Column(TypeName = "money")]
        public decimal Phi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUGIAOHANG> PHIEUGIAOHANGs { get; set; }
    }
}
