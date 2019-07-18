using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GasStationProject.Models
{
    public class GasStationAddVM
    {
        public long GasStationId { get; set; }

        public string GasStationName { get; set; }

        public string Address { get; set; }

        public string District { get; set; }
        public string OpeningTime { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }
        public string Rating { get; set; }

        public string Gatype { get; set; }
        
    }
}