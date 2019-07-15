namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GasStationGasType")]
    public partial class GasStationGasType
    {
        public long GasStationGasTypeId { get; set; }

        public long? GasStationId { get; set; }

        [StringLength(5)]
        public string GasType { get; set; }

        public virtual GasStation GasStation_LAPVT { get; set; }
    }
}
