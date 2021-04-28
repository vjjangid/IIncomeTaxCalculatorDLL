namespace IncomeTax.Core
{
    public class SurchargeTenPercent : ISurchargeTax
    {
        private static double taxRate = 0.10;

        public int GetSurcharge(int taxableIncome)
        {
            return (int)(taxRate * taxableIncome);
        }

    }
}
