using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    public class IncomeAndSalary : I_IncomeSalary
    {
        private double _BasicDAAmount;
        private double _HRA_Amount;
        private double _BonusCommissionAmount;
        private double _OtherAllowancesAmount;


        /// <summary>
        /// Income through basic salary and dearness allowance
        /// </summary>
        public double BasicDAAmount 
        {
            get
            {
                return _BasicDAAmount;
            }
            set
            {
                _BasicDAAmount = value;
            }
        }


        /// <summary>
        /// Income through House rent allowance 
        /// </summary>
        public double HRA_Amount 
        {
            get
            {
                return _HRA_Amount;
            }
            set
            {
                _HRA_Amount = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double BonusCommissionAmount 
        {
            get
            {
                return _BonusCommissionAmount;
            }
            set
            {
                _BonusCommissionAmount = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double OtherAllowancesAmount
        {
            get
            {
                return _OtherAllowancesAmount;
            }
            set
            {
                _OtherAllowancesAmount = value;
            }
        }
    }
}
