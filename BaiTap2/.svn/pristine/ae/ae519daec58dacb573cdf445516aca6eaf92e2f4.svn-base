namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Type
    {
        [Key]
        public long TypeId { get; set; }

        [Required]
        [StringLength(5)]
        public string TypeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeText { get; set; }

        public int TypeType { get; set; }
    }
}
