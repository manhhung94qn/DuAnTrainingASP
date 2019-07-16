using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GasStationProject.Models
{
    public class GasStationVM
    {
        public string GasStationName { get; set; }

        public List<string> GasStyle { get; set; }

        public string DistrictName { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }
}