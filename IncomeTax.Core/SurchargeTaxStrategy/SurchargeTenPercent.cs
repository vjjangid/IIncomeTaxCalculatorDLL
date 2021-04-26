using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
