namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    public class GeneralTaxSlab : ITaxSlabCharges
    {

        private const double taxRateFivePercent = 0.05;
        private const double taxRateTwentyPercent = 0.20;
        private const double taxRateThirtyPercent = 0.30;

        /// <summary>
        /// Caluclating tax for general age category which <=60
        /// </summary>
        /// <param name="taxableAmount">Total gross income</param>
        /// <returns></returns>
        public double CalculateTax(double taxableAmount)
        {
            double totalTax = 0;
            //No tax upto 250000
            if (taxableAmount <= 250000)
                return totalTax;

            taxableAmount -= 250000;

            //Five percent tax for next 250000;
            if (taxableAmount - 250000 <= 0)
            {
                totalTax += taxableAmount * taxRateFivePercent;
                return totalTax;
            }
            else
            {
                totalTax = (250000 * taxRateFivePercent);
                taxableAmount = taxableAmount - 250000;
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
