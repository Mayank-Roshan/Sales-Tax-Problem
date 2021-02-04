using SalesTaxProblem.Models;
using System;
using System.Collections.Generic;

namespace SalesTaxProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<ProductRequest> listProductOrder = new List<ProductRequest>();
            do
            {
                Console.WriteLine("Product Name:");
                var name = Console.ReadLine().Trim();
                Console.WriteLine("Category");
                var categry = Console.ReadLine().Trim();
                Console.WriteLine("Quantity:");
                var quantity = Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine("Price:");
                var price = float.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Is it imported, Yes or No?");
                var isImported = GetImportedInformation(Console.ReadLine().TrimEnd());
                listProductOrder.Add(new ProductRequest()
                {
                    Name = name,
                    Category = categry,
                    IsImported = true,
                    Price = price,
                    Quantity = quantity
                });
                Console.WriteLine("Enter y to comtinue");
                input = Console.ReadLine();
            }while(!string.Equals(input, "y", StringComparison.OrdinalIgnoreCase));

        }

        private static bool GetImportedInformation(string ForImportant)
        {
            return string.Equals(ForImportant, "yes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
