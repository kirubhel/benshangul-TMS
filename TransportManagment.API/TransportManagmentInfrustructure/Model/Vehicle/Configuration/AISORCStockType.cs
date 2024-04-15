﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagmentInfrustructure.Model.Authentication;
using static TransportManagmentInfrustructure.Enums.VehicleEnum;

namespace TransportManagmentInfrustructure.Model.Vehicle.Configuration
{
    public class AISORCStockType : SettingIdModel
    {
        [StringLength(10)]
        [Required]
        public string Name { get; set; } = null!;
        [StringLength(10)]
        [Required]
        public string AmharicName { get; set; } = null!;
        [StringLength(3)]
        [Required]
        public string Code { get; set; } = null!;
        [Required]
        public AISORCStockCategory Category { get; set; }
    }
}
