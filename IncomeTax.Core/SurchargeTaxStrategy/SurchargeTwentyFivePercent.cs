namespace IncomeTax.Core
{
    public class SurchargeTwentyFivePercent : ISurchargeTax
    {
        private static double _taxRate = 0.25;

        public int GetSurcharge(int taxableIncome)
        {
            return (int)(_taxRate * taxableIncome);
        }
    }
}
