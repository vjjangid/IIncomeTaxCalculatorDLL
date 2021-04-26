using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    public class SurchargeTwentyFivePercent : ISurchargeTax
    {
        private static double taxRate = 0.25;

        public int GetSurcharge(int taxableIncome)
        {
            return (int)(taxRate * taxableIncome);
        }
    }
}
