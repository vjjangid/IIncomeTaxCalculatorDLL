namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    public class SuperSeniorTaxSlab : ITaxSlabCharges
    {

        private const double taxRateTwentyPercent = 0.20;
        private const double taxRateThirtyPercent = 0.30;

        /// <summary>
        /// Calculate tax for super senior citizen
        /// </summary>
        /// <param name="taxableAmount"></param>
        /// <returns></returns>
        public double CalculateTax(double taxableAmount)
        {
            double totalTax = 0;

            //No tax upto 500000
            if (taxableAmount <= 500000)
                return totalTax;
            taxableAmount -= 500000;

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
