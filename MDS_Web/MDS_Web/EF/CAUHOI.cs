namespace MDS_Web.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUHOI")]
    public partial class CAUHOI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaCauHoi { get; set; }

        [Column("CauHoi")]
        [Required]
        [StringLength(200)]
        public string CauHoi1 { get; set; }

        [StringLength(200)]
        public string TraLoi1 { get; set; }

        [StringLength(200)]
        public string TraLoi2 { get; set; }

        [StringLength(200)]
        public string TraLoi3 { get; set; }

        [StringLength(200)]
        public string TraLoi4 { get; set; }

        [StringLength(200)]
        public string TraLoi5 { get; set; }

        public long? MaLoaiXe { get; set; }

        public virtual LOAIXE LOAIXE { get; set; }
    }
}
