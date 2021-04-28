namespace IncomeTax.Core
{
    public class SurchargeFifteenPercent : ISurchargeTax
    {
        private static double taxRate = 0.15;

        public int GetSurcharge(int taxableIncome)
        {
            return (int)(taxRate * taxableIncome);
        }
    }
}
