using IncomeTax.Core.CustomException;
using System;
using System.Text.RegularExpressions;

namespace IncomeTax.Core
{
    /// <summary>
    /// General purpose class to check the validity of the user amounts input
    /// </summary>
    public class Validator
    {

        /// <summary>
        /// Money should be positive integer amount
        /// </summary>
        /// <param name="enteredAmount"></param>
        /// <returns></returns>
        public static int ValidateMoneyAmount(int enteredAmount)
        {
            try
            {
                if(!int.TryParse(Convert.ToString(enteredAmount), out int result))
                {
                    throw new AmountException();
                }
            }
            catch(AmountException exc)
            {
                Console.WriteLine(exc.Message);
            }
            return Math.Max(0, enteredAmount);
        }

        /// <summary>
        /// Only india 91 format number is valid
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public static bool ValidateMobileNumber(string mobileNumber)
        {
            if (mobileNumber.Length == 12)
            {
                Match match = Regex.Match(mobileNumber, @"\A\G[9][1][1-9]\d{9}");
                if (match.Success)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Empty input is invalid
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ValidateNonEmptyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;
            return true;
        }

        /// <summary>
        /// Name should not contain any special symbols
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ValidateName(string input)
        {
            Match match = Regex.Match(input, "^[A-Z][a-zA-Z]*$");
            if (match.Success)
                return true;
            return false;
        }

        /// <summary>
        /// Below 16 and above 120 age is considered as invalid for
        /// this application
        /// </summary>
        /// <param name="age"> age of user</param>
        /// <returns></returns>
        public static bool ValidateDOB(int age)
        {
            return  age >= 16 && age <= 120 ;
        }
    }
}
