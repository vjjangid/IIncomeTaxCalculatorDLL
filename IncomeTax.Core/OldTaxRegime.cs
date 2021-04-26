using IncomeTax.Core.SurchargeTaxStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    /// <summary>
    /// Tax calculation based on old tax regime
    /// What do I need here
    /// ==> Exemption Deduction are present here --> Inherits Exemption and Deduction class
    /// ==> After exempting Deductions I get taxable income 
    /// ==> On this taxable income calculate Tax --> Use OldTaxRegimeSlab class 
    /// ==> Calculate the surcharge on total income --> Implements ISurcharge interface
    /// ==> Calculate the health surcharge on total tax --> Implements the Health Surcharge interface
    /// </summary>
    public class OldTaxRegime : ExemptionsAndDeductions, IHealthAndEducationSurcharge
    {

        private int _totalIncome;
        private int _hraAmount;
        private int _basicDaAmount;
        private int _rentPaid;
        private bool _metroStatus;
        private int _totalTaxableAmount;


        #region Constructor

        public OldTaxRegime(int totalIncome, int hraAmount, int basicDaAmount, bool metroStatus )
        {
            _totalIncome = totalIncome;
            _hraAmount = hraAmount;
            _basicDaAmount = basicDaAmount;
            _rentPaid = IDeduction80GGAAmount;
            _metroStatus = metroStatus;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Health surcharge is applicable on taxable income
        /// </summary>
        /// <returns></returns>
        public int GetHelathSurcharge()
        {
            return (int)(0.04 * _totalTaxableAmount);
        }

        /// <summary>
        /// Total cess surcharge on taxable income
        /// </summary>
        /// <returns></returns>
        public int GetSurcharge()
        {
            SurchargeTax surchargeTax = new SurchargeTax(_totalTaxableAmount);
            return surchargeTax.TotalSurchageTax();
        }

        /// <summary>
        /// Total tax calculation according to old Tax regime
        /// </summary>
        /// <param name="ageClass"></param>
        /// <returns></returns>
        public int GetTotalTax(AgeCategory ageClass)
        {
            int totalExemption = TotalExmeption();
            totalExemption += HraExemptions(_hraAmount, _basicDaAmount, _rentPaid, _metroStatus);

            _totalTaxableAmount = _totalIncome - totalExemption;

            OldRegimeTaxSlab oldRegimeTaxSlab = new OldRegimeTaxSlab();

            int totalTax = oldRegimeTaxSlab.calculateTax(ageClass, _totalTaxableAmount);
            totalTax += GetSurcharge() + GetHelathSurcharge();

            return totalTax;

        }

        #endregion
    }
}
