namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    public class SeniorTaxSlab : ITaxSlabCharges
    {

        private const double taxRateFivePercent = 0.05;
        private const double taxRateTwentyPercent = 0.20;
        private const double taxRateThirtyPercent = 0.30;

        /// <summary>
        /// Calculating tax for senior citizen category
        /// </summary>
        /// <param name="taxableAmount">the total gross income</param>
        /// <returns></returns>
        public double CalculateTax(double taxableAmount)
        {
            double totalTax = 0;
            //No tax upto 300000
            if (taxableAmount <= 300000)
                return totalTax;

            //No tax upto 300000
            taxableAmount -= 300000;

            //Five percent tax for next 200000;
            if (taxableAmount - 200000 <= 0)
            {
                totalTax += taxableAmount * taxRateFivePercent;
                return totalTax;
            }
            else
            {
                totalTax = (200000 * taxRateFivePercent);
                taxableAmount = taxableAmount - 200000;
            }

            //20 percent tax for next  5 lakhs
            if (taxableAmount - 500000 <= 0)
            {
                totalTax += taxableAmount * taxRateTwentyPercent;
                return totalTax;
            }
            else
            {
                totalTax += 500000 * taxRateTwentyPercent;
                taxableAmount = taxableAmount - 500000;
            }

            //30 percent tax for remaining amount
            totalTax += taxableAmount * taxRateThirtyPercent;

            return totalTax;
        }

    }
}
