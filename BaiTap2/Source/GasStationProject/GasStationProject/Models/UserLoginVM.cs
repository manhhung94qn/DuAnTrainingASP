using GasStationProject.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GasStationProject.Models
{
    public class UserLoginVM
    {

        [Display(Name = "D0002", ResourceType = typeof(Resource))]
        public string Email { get; set; }

        [Display(Name = "D0003", ResourceType =typeof(Resource))]
        public string Password { get; set; }
    }
}