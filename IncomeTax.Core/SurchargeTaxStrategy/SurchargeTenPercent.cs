namespace IncomeTax.Core
{
    public class SurchargeTenPercent : ISurchargeTax
    {
        private static double _taxRate = 0.10;

        public int GetSurcharge(int taxableIncome)
        {
            return (int)(_taxRate * taxableIncome);
        }

    }
}
