namespace IncomeTax.Core
{
    public class SurchargeThirtySevenPercent : ISurchargeTax
    {
        private static double taxRate = 0.37;
        public int GetSurcharge(int taxableIncome)
        {
            return (int)(taxRate * taxableIncome);
        }
    }
}
