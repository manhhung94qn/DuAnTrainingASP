namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_District
    {
        [Key]
        public long DistrictId { get; set; }

        [StringLength(50)]
        public string DistrictName { get; set; }
    }
}
