using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxTest
{
    /// <summary>
    /// New regime tax slab
    /// </summary>
    class NewRegimeTaxSlab
    {
        
        /// <summary>
        /// Calculate tax according to new tax regime
        /// </summary>
        /// <param name="taxableAmount">Taxable income</param>
        /// <returns></returns>
        public int Calculate(double taxableAmount)
        {
            double totalTax = 0;
            //No tax upto 500000
            if (taxableAmount <= 250000)
                return (int)totalTax;

            //No tax upto 500000
            taxableAmount -= 250000;

            Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            Console.WriteLine("Total tax till now is :: " + totalTax);

            if (taxableAmount - 250000 <= 0)
            {
                Console.WriteLine("5 percent if");
                totalTax += taxableAmount * (0.05);
                Console.WriteLine("Total Tax :: " + totalTax);
                return (int)totalTax;
            }
            else
            {
                Console.WriteLine("5 percent else");
                totalTax += 250000 * (0.05);
                taxableAmount = taxableAmount - 250000;
            }

            //10 percent tax for next  2.5 lakhs
            if (taxableAmount - 250000 <= 0)
            {
                Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.1);
                Console.WriteLine("Total Tax :: " + totalTax);
                return (int)totalTax;
            }
            else
            {
                Console.WriteLine("20 percent else");
                totalTax += 250000 * (0.1);
                taxableAmount = taxableAmount - 250000;
            }

            //15 percent for next 2.5 lakh
            if (taxableAmount - 250000 <= 0)
            {
                Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.15);
                Console.WriteLine("Total Tax :: " + totalTax);
                return (int)totalTax;
            }
            else
            {
                Console.WriteLine("20 percent else");
                totalTax += 250000 * (0.15);
                taxableAmount = taxableAmount - 250000;
            }

            //20 percent for next 2.5 lakh
            if (taxableAmount - 250000 <= 0)
            {
                Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.20);
                Console.WriteLine("Total Tax :: " + totalTax);
                return (int)totalTax;
            }
            else
            {
                Console.WriteLine("20 percent else");
                totalTax += 250000 * (0.20);
                taxableAmount = taxableAmount - 250000;
            }

            //25 percent for next 2.5 lakh
            if (taxableAmount - 250000 <= 0)
            {
                Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.25);
                Console.WriteLine("Total Tax :: " + totalTax);
                return (int)totalTax;
            }
            else
            {
                Console.WriteLine("20 percent else");
                totalTax += 250000 * (0.25);
                taxableAmount = taxableAmount - 250000;
            }

            Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            Console.WriteLine("Total tax till now is :: " + totalTax);

            //30 percent tax for remaining amount
            totalTax += taxableAmount * (0.3);

            Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            Console.WriteLine("Total tax till now is :: " + totalTax);
            return (int)totalTax;
        }
    }
}
