﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAbstract
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public string NID { get; set; }
        public DateTime RegDate { get; set; }
    }
}
