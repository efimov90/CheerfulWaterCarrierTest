﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.Models
{
    public class OrderModel
    {
        public int? OrderId { get; set; }
        public string ProductName { get; set; }
        public int EmployeeId { get; set; }
    }
}
