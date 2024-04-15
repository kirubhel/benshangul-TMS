﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagmentInfrustructure.Model.Authentication;

namespace TransportManagmentInfrustructure.Model.Vehicle.Configuration
{
    public class VehicleBodyType: SettingIdModel
    {
        [StringLength(10)]
        [Required]
        public string Name { get; set; } = null!;
        [StringLength(20)]
        [Required]
        public string AmharicName { get; set; } = null!;
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; } = null!;
    }
}
