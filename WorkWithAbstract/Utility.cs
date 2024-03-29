﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAbstract
{
    public class Utility
    {
        public static List<Order> OrderList { set; get; } = new List<Order>();
        public enum OrderType
        {
            GadgetOrder=1,
            FoodOrder = 2,
            FinishedOrder=3
        }
        public const double GadgetDiscount = 10;
        public const double FoodDiscount = 5;
    }
}
