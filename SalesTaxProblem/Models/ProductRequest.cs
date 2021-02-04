using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxProblem.Models
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public bool IsImported { get; set; }
    }
}
