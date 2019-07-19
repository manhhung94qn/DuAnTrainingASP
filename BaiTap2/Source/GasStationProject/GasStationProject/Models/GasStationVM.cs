using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GasStationProject.Models
{
    public class GasStationVM
    {
        public long GasStationId { get; set; }
        public string GasStationName { get; set; }

        public string GasType { get; set; }

        public string DistrictName { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }
}