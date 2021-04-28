using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


                                                 /// <summary>
                                                 /// Leaving one doubt here what if user
                                                 /// enters the string amount? Does application
                                                 /// will crash? Will check it later
                                                 /// </summary>
namespace IncomeTax.Core
{
    /// <summary>
    /// Income and Salary ==> Takes the revenue you made for gross salary
    /// </summary>
    public class IncomeAndSalary : IIncomeSalary, IDeductionIncomeBusinessProfession, IIncomeCapitalGains, IIncomeOtherSources 
    {

        #region Properties

        private int _BasicDAAmount;
        private int _HRA_Amount;
        private int _BonusCommissionAmount;
        private int _OtherAllowancesAmount;
        private int _BusinessAmount;
        private int _ProfessionAmount;
        private int _ShortTermCGNormalRatesAmount;
        private int _ShortTermCG15Amount;
        private int _LongTermCG10;
        private int _LongTermCG20;
        private int _InterestSavingsBankAccounts;
        private int _InterestFixedDeposits;
        private int _OtherSources;

        #endregion

        #region Salary

        /// <summary>
        /// Income through basic salary and dearness allowance
        /// </summary>
        public int BasicDAAmount 
        {
            get
            {
                return _BasicDAAmount;
            }
            set
            {
                _BasicDAAmount = Validator.ValidateMoneyAmount(value);
                
            }
        }


        /// <summary>
        /// Income through House rent allowance 
        /// </summary>
        public int HRA_Amount 
        {
            get
            {
                return _HRA_Amount;
            }
            set
            {
                _HRA_Amount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Exemptions through bonus and salary
        /// </summary>
        public int BonusCommissionAmount 
        {
            get
            {
                return _BonusCommissionAmount;
            }
            set
            {
                _BonusCommissionAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Exemptions through other allowances
        /// </summary>
        public int OtherAllowancesAmount
        {
            get
            {
                return _OtherAllowancesAmount;
            }
            set
            {
                _OtherAllowancesAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region Business Profession

        /// <summary>
        /// Income through Business and Profession
        /// </summary>
        public int BusinessAmount 
        {
            get
            {
                return _BusinessAmount;
            }
            set
            {
                _BusinessAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Profession
        /// </summary>
        public int ProfessionAmount
        {
            get
            {
                return _ProfessionAmount;
            }
            set
            {
                _ProfessionAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region Capital Gains

        /// <summary>
        /// Income through Short Term Capital Gains on Normal rates
        /// </summary>
        public int ShortTermCGNormalRates 
        {
            get
            {
                return _ShortTermCGNormalRatesAmount;
            }
            set
            {
                _ShortTermCGNormalRatesAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Short Term Capital Gains at 15 percent rate
        /// </summary>
        public int ShortTermCG15 
        {
            get
            {
                return _ShortTermCG15Amount;
            }
            set
            {
                _ShortTermCG15Amount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Long Term capital gains at 10 % rate
        /// </summary>
        public int LongTermCG10 
        {
            get
            {
                return _LongTermCG10;
            }
            set
            {
                _LongTermCG10 = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Long Term Capital Gain at 20% rate
        /// </summary>
        public int LongTermCG20 
        {
            get
            {
                return _LongTermCG20;
            }
            set
            {
                _LongTermCG20 = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region Other Sources

        /// <summary>
        /// Income through Savings in Bank Accounts
        /// </summary>
        public int InterestSavingsBankAccounts 
        {
            get
            {
                return _InterestSavingsBankAccounts;
            }
            set
            {
                _InterestSavingsBankAccounts = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Interest on Fixed Deposits
        /// </summary>
        public int InterestFixedDeposits 
        {
            get
            {
                return _InterestFixedDeposits;
            }
            set
            {
                _InterestFixedDeposits = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income throught other sources
        /// </summary>
        public int OtherSources 
        {
            get
            {
                return _OtherSources;
            }
            set
            {
                _OtherSources = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion


        /// <summary>
        /// Total income by all sources of the user
        /// </summary>
        /// <returns></returns>
        public int TotalSalaryAndIncome()
        {
            return ( _BasicDAAmount +  _HRA_Amount + _BonusCommissionAmount + _OtherAllowancesAmount +
                     _BusinessAmount + _ProfessionAmount + _ShortTermCGNormalRatesAmount +_ShortTermCG15Amount +
                    _LongTermCG10 + _LongTermCG20 + _InterestSavingsBankAccounts + _InterestFixedDeposits + 
                    _OtherSources ) ;
        }

    }
}
