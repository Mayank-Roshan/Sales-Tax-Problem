﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxDomain.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public bool IsImported { get; set; }
        public float TotalTaxPercentage { get; set; }
        public float TotalPrice { get; set; }
    }
}
