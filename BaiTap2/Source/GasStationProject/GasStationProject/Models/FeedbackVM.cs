using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationProject.Models
{
    public class FeedbackVM
    {
        public string GasStationName {get; set;}
        public string GasType { get; set; }
        public string GasAddress { get; set; }
        public string OpenTime { get; set; }
        public string Rating { get; set; }
        public List<string> Feedback { get; set; }
    }
}