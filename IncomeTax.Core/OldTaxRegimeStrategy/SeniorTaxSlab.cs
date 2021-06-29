namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    public class SeniorTaxSlab : ITaxSlabCharges
    {
        private const double TaxRateFivePercent = 0.05;
        private const double TaxRateTwentyPercent = 0.20;
        private const double TaxRateThirtyPercent = 0.30;

        /// <summary>
        /// Calculating tax for senior citizen category
        /// </summary>
        /// <param name="taxableAmount">the total gross income</param>
        /// <returns></returns>
        public double CalculateTax(double taxableAmount)
        {
            double totalTax = 0;
            //No tax till 300000
            if (taxableAmount <= 300000)
                return totalTax;

            taxableAmount -= 300000;

            //Five percent tax for next 200000;
            if (taxableAmount - 200000 <= 0)
            {
                totalTax += taxableAmount * TaxRateFivePercent;
                return totalTax;
            }
            else
            {
                totalTax = 200000 * TaxRateFivePercent;
                taxableAmount -= 200000;
            }

            //20 percent tax for next  5 lakh
            if (taxableAmount - 500000 <= 0)
            {
                totalTax += taxableAmount * TaxRateTwentyPercent;
                return totalTax;
            }
            else
            {
                totalTax += 500000 * TaxRateTwentyPercent;
                taxableAmount -= 500000;
            }

            //30 percent tax for remaining amount
            totalTax += taxableAmount * TaxRateThirtyPercent;
            return totalTax;
        }
    }
}
