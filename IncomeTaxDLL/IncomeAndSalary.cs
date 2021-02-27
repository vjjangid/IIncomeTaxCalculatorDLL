using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    /// <summary>
    /// Income and Salary ==> Takes the revenue you made for gross salary
    /// </summary>
    public class IncomeAndSalary : I_IncomeSalary, I_DeductionIncomeBusinessProfession, I_IncomeCapitalGains, I_IncomeOtherSources 
    {

        #region Properties

        private double _BasicDAAmount;
        private double _HRA_Amount;
        private double _BonusCommissionAmount;
        private double _OtherAllowancesAmount;
        private double _BusinessAmount;
        private double _ProfessionAmount;
        private double _ShortTermCGNormalRatesAmount;
        private double _ShortTermCG15Amount;
        private double _LongTermCG10;
        private double _LongTermCG20;
        private double _InterestSavingsBankAccounts;
        private double _InterestFixedDeposits;
        private double _OtherSources;

        #endregion

        #region Salary

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
        /// Exemptions through bonus and salary
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
        /// Exemptions through other allowances
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

        #endregion

        #region Business Profession

        /// <summary>
        /// Income through Business and Profession
        /// </summary>
        public double BusinessAmount 
        {
            get
            {
                return _BusinessAmount;
            }
            set
            {
                _BusinessAmount = value;
            }
        }

        /// <summary>
        /// Income through Profession
        /// </summary>
        public double ProfessionAmount
        {
            get
            {
                return _ProfessionAmount;
            }
            set
            {
                _ProfessionAmount = value;
            }
        }

        #endregion

        #region Capital Gains

        /// <summary>
        /// Income through Short Term Capital Gains on Normal rates
        /// </summary>
        public double ShortTermCGNormalRates 
        {
            get
            {
                return _ShortTermCGNormalRatesAmount;
            }
            set
            {
                _ShortTermCGNormalRatesAmount = value;
            }
        }

        /// <summary>
        /// Income through Short Term Capital Gains at 15 percent rate
        /// </summary>
        public double ShortTermCG15 
        {
            get
            {
                return _ShortTermCG15Amount;
            }
            set
            {
                _ShortTermCG15Amount = value;
            }
        }

        /// <summary>
        /// Income through Long Term capital gains at 10 % rate
        /// </summary>
        public double LongTermCG10 
        {
            get
            {
                return _LongTermCG10;
            }
            set
            {
                _LongTermCG10 = value;
            }
        }

        /// <summary>
        /// Income through Long Term Capital Gain at 20% rate
        /// </summary>
        public double LongTermCG20 
        {
            get
            {
                return _LongTermCG20;
            }
            set
            {
                _LongTermCG20 = value;
            }
        }


        #endregion

        #region Other Sources

        /// <summary>
        /// Income through Savings in Bank Accounts
        /// </summary>
        public double InterestSavingsBankAccounts 
        {
            get
            {
                return _InterestSavingsBankAccounts;
            }
            set
            {
                _InterestSavingsBankAccounts = value;
            }
        }

        /// <summary>
        /// Income through Interest on Fixed Deposits
        /// </summary>
        public double InterestFixedDeposits 
        {
            get
            {
                return _InterestFixedDeposits;
            }
            set
            {
                _InterestFixedDeposits = value;
            }
        }

        /// <summary>
        /// Income throught other sources
        /// </summary>
        public double OtherSources 
        {
            get
            {
                return _OtherSources;
            }
            set
            {
                _OtherSources = value;
            }
        }

        #endregion

    }
}
