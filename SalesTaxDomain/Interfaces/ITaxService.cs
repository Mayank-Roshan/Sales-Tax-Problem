using SalesTaxDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxDomain.Interfaces
{
    interface ITaxService
    {
        float GetTotaltaxPercentageOnProduct(Product product);

        float CalculateTotalProductPriceAfterTaxation(Product product);
    }
}
