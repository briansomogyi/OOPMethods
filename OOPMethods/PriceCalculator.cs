using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal static class PriceCalculator
    {
        /// <summary>
        /// Calculates the product price
        /// </summary>
        /// <param name="unitPrice">The unit price</param>
        /// <param name="quantity">The quantity</param>
        /// <param name="vatPercent">The VAT Percentage. E.g.: if VAT is 19%, then pass 19.</param>
        /// <returns></returns>
        public static decimal CalculatePrice(decimal unitPrice, decimal quantity = 1M, decimal vatPercent = 19M)
        {
            return unitPrice * quantity * (1 + (vatPercent / 100));
        }
    }
}
