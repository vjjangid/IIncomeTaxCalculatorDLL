using System;
using System.Text.RegularExpressions;

namespace IncomeTax.Core
{
    /// <summary>
    /// General purpose class to check the validity of the user amounts input
    /// </summary>
    public class InputValidity
    {
        public static int ValidAmounts(int enteredAmount)
        {
            try
            {
                if(!int.TryParse(Convert.ToString(enteredAmount), out int result))
                {
                    throw new ArgumentException("Invalid input");
                }
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            return Math.Max(0, enteredAmount);
        }

        public static bool ValidMobileNumber(string MobileNumber)
        {
            if (MobileNumber.Length == 12)
            {
                Match match = Regex.Match(MobileNumber, @"\A\G[9][1][1-9]\d{9}");
                if (match.Success)
                    return true;
            }
            return false;
        }
    }
}
