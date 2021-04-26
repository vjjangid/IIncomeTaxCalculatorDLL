using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
