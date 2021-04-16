using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    /// <summary>
    /// New Tax regime of Income Tax
    /// </summary>
    public class NewTaxRegime : IHealthAndEducationSurcharge, ISurchargeTax
    {

        private double _totalTaxPayableAmount;

        #region Properties
        public bool Surcharge10Percent { get; set; }

        public bool Surcharge15Percent { get; set; }

        public bool Surcharge25Percent { get; set; }

        public bool Surcharge37Percent { get; set; }

        #endregion

        #region Constructor
        public NewTaxRegime(int totalTaxPayableAmount)
        {
            _totalTaxPayableAmount = totalTaxPayableAmount;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Health surcharge on totla taxable income
        /// </summary>
        /// <returns></returns>
        public int GetHelathSurcharge()
        {
            return (int)(0.04 * _totalTaxPayableAmount);
        }

        /// <summary>
        /// Surcharge applicable on total taxable income
        /// </summary>
        /// <returns></returns>
        public int GetSurcharge()
        {
            if (_totalTaxPayableAmount > 500000000)
            {
                Surcharge37Percent = true;
                return (int)(0.37 * _totalTaxPayableAmount);
            }
            if (_totalTaxPayableAmount > 200000000)
            {
                Surcharge25Percent = true;
                return (int)(0.25 * _totalTaxPayableAmount);
            }
            if (_totalTaxPayableAmount > 100000000)
            {
                Surcharge15Percent = true;
                return (int)(0.15 * _totalTaxPayableAmount);
            }
            if (_totalTaxPayableAmount > 5000000)
            {
                Surcharge10Percent = true;
                return (int)(0.10 * _totalTaxPayableAmount);
            }
            return 0;
        }

        /// <summary>
        /// New Tax regime slab
        /// </summary>
        /// <returns></returns>
        private int NewRegimeAllCategoryTax()
        {
            double totalTax = 0;
            //No tax upto 500000
            if (_totalTaxPayableAmount <= 250000)
                return (int)totalTax;

            //No tax upto 500000
            _totalTaxPayableAmount -= 250000;

            if (_totalTaxPayableAmount - 500000 <= 0)
            {
                totalTax += _totalTaxPayableAmount * (0.05);
                return (int)totalTax;
            }
            else
            {
                totalTax += 500000 * (0.05);
                _totalTaxPayableAmount = _totalTaxPayableAmount - 250000;
            }

            //10 percent tax for next  2.5 lakhs
            if (_totalTaxPayableAmount - 250000 <= 0)
            {
                totalTax += _totalTaxPayableAmount * (0.1);
                return (int)totalTax;
            }
            else
            {
                totalTax += 250000 * (0.2);
                _totalTaxPayableAmount = _totalTaxPayableAmount - 250000;
            }

            //15 percent for next 2.5 lakh
            if (_totalTaxPayableAmount - 250000 <= 0)
            {
                totalTax += _totalTaxPayableAmount * (0.15);
                return (int)totalTax;
            }
            else
            {
                totalTax += 250000 * (0.15);
                _totalTaxPayableAmount = _totalTaxPayableAmount - 250000;
            }

            //20 percent for next 2.5 lakh
            if (_totalTaxPayableAmount - 250000 <= 0)
            {
                totalTax += _totalTaxPayableAmount * (0.20);
                return (int)totalTax;
            }
            else
            {
                 totalTax += 250000 * (0.20);
                _totalTaxPayableAmount = _totalTaxPayableAmount - 250000;
            }

            //25 percent for next 2.5 lakh
            if (_totalTaxPayableAmount - 250000 <= 0)
            {
                totalTax += _totalTaxPayableAmount * (0.25);
                return (int)totalTax;
            }
            else
            {
                 totalTax += 250000 * (0.25);
                _totalTaxPayableAmount = _totalTaxPayableAmount - 250000;
            }

            //30 percent tax for remaining amount
            totalTax += _totalTaxPayableAmount * (0.3);
            return (int)totalTax;
        }

        /// <summary>
        /// Total calcualted tax according to new regime
        /// </summary>
        /// <returns></returns>
        public int TotalTax()
        {
            return NewRegimeAllCategoryTax() + GetHelathSurcharge() + GetSurcharge();
        }

        #endregion
    }
}
