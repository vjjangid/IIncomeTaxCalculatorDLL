namespace IncomeTax.Core
{
    public class SurchargeFifteenPercent : ISurchargeTax
    {
        private const double TaxRate = 0.15;

        public int GetSurcharge(int taxableIncome)
        {
            return (int)(TaxRate * taxableIncome);
        }
    }
}
