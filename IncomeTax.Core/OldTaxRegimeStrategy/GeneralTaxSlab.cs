using System;
using NUnit.Framework;

namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    public class GeneralTaxSlab : ITaxSlabCharges
    {
        private const double TaxRateFivePercent = 0.05;
        private const double TaxRateTwentyPercent = 0.20;
        private const double TaxRateThirtyPercent = 0.30;

        /// <summary>
        /// Calculating tax for general age category which is less than equal 60
        /// </summary>
        /// <param name="taxableAmount">Total gross income</param>
        /// <returns></returns>
        public double CalculateTax(double taxableAmount)
        {
            if (taxableAmount < 0)
                return 0;

            double totalTax = 0;

            //No tax till 250000
            if (taxableAmount <= 250000)
                return totalTax;

            taxableAmount -= 250000;

            //Five percent tax for next 250000;
            if (taxableAmount - 250000 <= 0)
            {
                totalTax += taxableAmount * TaxRateFivePercent;
                return totalTax;
            }
            else
            {
                totalTax = (250000 * TaxRateFivePercent);
                taxableAmount -= 250000;
            }

            //20 percent tax for next  5 lakh
            if (taxableAmount - 500000 <= 0)
            {
                totalTax += taxableAmount *TaxRateTwentyPercent;
                return totalTax;
            }
            else
            {
                Console.WriteLine("Else 5 lakh");
                totalTax += 500000 *TaxRateTwentyPercent;
                taxableAmount -= 500000;
            }

            //30 percent tax for remaining amount
            totalTax += taxableAmount * TaxRateThirtyPercent;
            return totalTax;
        }
    }
}
