﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclePriceCalculator.Domain.Enum;

namespace VehiclePriceCalculator.Domain.Model
{
    public class VehicleCalculateModel
    {

        public decimal BasePrice { get; set; }
        public VehicleType VehicleType { get; set; }
        public decimal StorageFee { get; set; }

    }
}
