﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAbstract
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string CustomerId { get; set; }
        public double Discount { get; set; }
        public double Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderType { get; set; }
    }
}
