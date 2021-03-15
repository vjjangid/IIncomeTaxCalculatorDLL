using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    /// <summary>
    /// General purpose class to check the validity of the user amounts input
    /// </summary>
    public class InputValidity
    {
        public static int ValidAmounts(int enteredAmount)
        {
            return Math.Max(0, enteredAmount);
        }
    }
}
