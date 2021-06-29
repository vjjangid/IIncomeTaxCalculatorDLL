namespace IncomeTax.Core
{
    public class SurchargeThirtySevenPercent : ISurchargeTax
    {
        private static double _taxRate = 0.37;
        public int GetSurcharge(int taxableIncome)
        {
            return (int)(_taxRate * taxableIncome);
        }
    }
}
