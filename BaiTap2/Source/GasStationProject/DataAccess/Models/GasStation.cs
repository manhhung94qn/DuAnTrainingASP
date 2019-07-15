namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GasStation")]
    public partial class GasStation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GasStation()
        {
            GasStationFeedback = new HashSet<GasStationFeedback>();
            GasStationGasType = new HashSet<GasStationGasType>();
        }

        [Key]
        public long GasStationId { get; set; }

        [Required]
        [StringLength(100)]
        public string GasStationName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public long District { get; set; }

        [StringLength(50)]
        public string OpeningTime { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }

        public DateTime InsertedAt { get; set; }

        public long InsertedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public long UpdatedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

        public long? DeletedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GasStationFeedback> GasStationFeedback { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GasStationGasType> GasStationGasType { get; set; }
    }
}
