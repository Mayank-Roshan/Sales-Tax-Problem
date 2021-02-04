using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SalesTaxDomain.Constants
{
    public static class SalesTaxConstants
    {
        public static readonly IList<String> ExemptionCategories = new ReadOnlyCollection<string>
                                                            (new List<String> {
                                                                "Book",
                                                                "Food",
                                                                "MedicalProducts"
                                                            });
        public const float ImportTaxPercentage = 5.0f;
        public const float SalesTaxPercentage = 10.0f;
    }
}
