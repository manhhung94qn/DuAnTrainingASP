namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GasStationFeedback")]
    public partial class GasStationFeedback
    {
        public long GasStationFeedbackId { get; set; }

        public long GasStationId { get; set; }

        [Required]
        [StringLength(500)]
        public string Feedback { get; set; }

        public DateTime FeedbackAt { get; set; }

        public long? FeedbackBy { get; set; }

        public virtual GasStation GasStation { get; set; }
    }
}
