using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    /// <summary>
    /// Tax slabs under old tax regime
    /// </summary>
    public class OldRegimeTaxSlab
    {
        
        /// <summary>
        /// Only public function to calculate the tax
        /// </summary>
        /// <param name="ageCategory">Age category of person</param>
        /// <param name="taxableAmount">Taxable amount</param>
        /// <returns></returns>
        public int calculateTax(AgeCategory ageCategory, double taxableAmount)
        {
            double totalTax = 0;

            if (ageCategory == AgeCategory.General)
                totalTax = CalcualteGeneralSlabTaxOldRegime(taxableAmount);
            else if (ageCategory == AgeCategory.Senior)
                totalTax = CalcualteSeniorSlabTaxOldRegime(taxableAmount);
            else
                totalTax = CalcualteSuperSeniorSlabTaxOldRegime(taxableAmount);

            return (int)(totalTax);
        }


        /// <summary>
        /// Caluclating tax for general age category which <=60
        /// </summary>
        /// <param name="taxableAmount">Total gross income</param>
        /// <returns></returns>
        private double CalcualteGeneralSlabTaxOldRegime(double taxableAmount)
        {
            double totalTax = 0;
            //No tax upto 250000
            if (taxableAmount <= 250000)
                return totalTax;

            //No tax upto 250000
            taxableAmount -= 250000;
            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //Five percent tax for next 250000;
            if (taxableAmount - 250000 <= 0)
            {
                //Console.WriteLine("5 percent if");
                totalTax += taxableAmount * (0.05);
                return totalTax;
            }
            else
            {
                //Console.WriteLine("5 percent else");
                totalTax = (250000 * 0.05);
                taxableAmount = taxableAmount - 250000;
            }

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //20 percent tax for next  5 lakhs
            if (taxableAmount - 500000 <= 0)
            {
                //Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.2);
                //Console.WriteLine("Total Tax :: " + totalTax);
                return totalTax;
            }
            else
            {
                //Console.WriteLine("20 percent else");
                totalTax += 500000 * (0.2);
                taxableAmount = taxableAmount - 500000;
            }

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //30 percent tax for remaining amount
            totalTax += taxableAmount * (0.3);

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);
            return totalTax;

        }

        /// <summary>
        /// Calculating tax for senior citizen category
        /// </summary>
        /// <param name="taxableAmount">the total gross income</param>
        /// <returns></returns>
        private double CalcualteSeniorSlabTaxOldRegime(double taxableAmount)
        {
            double totalTax = 0;
            //No tax upto 300000
            if (taxableAmount <= 300000)
                return totalTax;

            //No tax upto 300000
            taxableAmount -= 300000;
            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //Five percent tax for next 200000;
            if (taxableAmount - 200000 <= 0)
            {
                //Console.WriteLine("5 percent if");
                totalTax += taxableAmount * (0.05);
                return totalTax;
            }
            else
            {
                //Console.WriteLine("5 percent else");
                totalTax = (200000 * 0.05);
                taxableAmount = taxableAmount - 200000;
            }

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //20 percent tax for next  5 lakhs
            if (taxableAmount - 500000 <= 0)
            {
                //Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.2);
                //Console.WriteLine("Total Tax :: " + totalTax);
                return totalTax;
            }
            else
            {
                //Console.WriteLine("20 percent else");
                totalTax += 500000 * (0.2);
                taxableAmount = taxableAmount - 500000;
            }

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //30 percent tax for remaining amount
            totalTax += taxableAmount * (0.3);

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);
            return totalTax;

        }

        /// <summary>
        /// Calculate tax for super senior citizen
        /// </summary>
        /// <param name="taxableAmount"></param>
        /// <returns></returns>
        private double CalcualteSuperSeniorSlabTaxOldRegime(double taxableAmount)
        {
            double totalTax = 0;
            //No tax upto 500000
            if (taxableAmount <= 500000)
                return totalTax;

            //No tax upto 500000
            taxableAmount -= 500000;
            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);


            //20 percent tax for next  5 lakhs
            if (taxableAmount - 500000 <= 0)
            {
                //Console.WriteLine("20 percent if");
                totalTax += taxableAmount * (0.2);
                //Console.WriteLine("Total Tax :: " + totalTax);
                return totalTax;
            }
            else
            {
                //Console.WriteLine("20 percent else");
                totalTax += 500000 * (0.2);
                taxableAmount = taxableAmount - 500000;
            }

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);

            //30 percent tax for remaining amount
            totalTax += taxableAmount * (0.3);

            //Console.WriteLine("total Gross Salary is :: " + taxableAmount);
            //Console.WriteLine("Total tax till now is :: " + totalTax);
            return totalTax;

        }
    }
}
