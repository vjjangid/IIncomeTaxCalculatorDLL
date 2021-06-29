using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncomeTax.Core.GeneralInterfaces;


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

        private int _basicDaAmount;
        private int _hraAmount;
        private int _bonusCommissionAmount;
        private int _otherAllowancesAmount;
        private int _businessAmount;
        private int _professionAmount;
        private int _shortTermCgNormalRatesAmount;
        private int _shortTermCg15Amount;
        private int _longTermCg10;
        private int _longTermCg20;
        private int _interestSavingsBankAccounts;
        private int _interestFixedDeposits;
        private int _otherSources;

        #endregion

        #region Salary

        /// <summary>
        /// Income through basic salary and dearness allowance
        /// </summary>
        public int BasicDAAmount 
        {
            get
            {
                return _basicDaAmount;
            }
            set
            {
                _basicDaAmount = Validator.ValidateMoneyAmount(value);
                
            }
        }


        /// <summary>
        /// Income through House rent allowance 
        /// </summary>
        public int HRA_Amount 
        {
            get
            {
                return _hraAmount;
            }
            set
            {
                _hraAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Exemptions through bonus and salary
        /// </summary>
        public int BonusCommissionAmount 
        {
            get
            {
                return _bonusCommissionAmount;
            }
            set
            {
                _bonusCommissionAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Exemptions through other allowances
        /// </summary>
        public int OtherAllowancesAmount
        {
            get
            {
                return _otherAllowancesAmount;
            }
            set
            {
                _otherAllowancesAmount = Validator.ValidateMoneyAmount(value);
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
                return _businessAmount;
            }
            set
            {
                _businessAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Profession
        /// </summary>
        public int ProfessionAmount
        {
            get
            {
                return _professionAmount;
            }
            set
            {
                _professionAmount = Validator.ValidateMoneyAmount(value);
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
                return _shortTermCgNormalRatesAmount;
            }
            set
            {
                _shortTermCgNormalRatesAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Short Term Capital Gains at 15 percent rate
        /// </summary>
        public int ShortTermCG15 
        {
            get
            {
                return _shortTermCg15Amount;
            }
            set
            {
                _shortTermCg15Amount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Long Term capital gains at 10 % rate
        /// </summary>
        public int LongTermCG10 
        {
            get
            {
                return _longTermCg10;
            }
            set
            {
                _longTermCg10 = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Long Term Capital Gain at 20% rate
        /// </summary>
        public int LongTermCG20 
        {
            get
            {
                return _longTermCg20;
            }
            set
            {
                _longTermCg20 = Validator.ValidateMoneyAmount(value);
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
                return _interestSavingsBankAccounts;
            }
            set
            {
                _interestSavingsBankAccounts = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income through Interest on Fixed Deposits
        /// </summary>
        public int InterestFixedDeposits 
        {
            get
            {
                return _interestFixedDeposits;
            }
            set
            {
                _interestFixedDeposits = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Income throught other sources
        /// </summary>
        public int OtherSources 
        {
            get
            {
                return _otherSources;
            }
            set
            {
                _otherSources = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion


        /// <summary>
        /// Total income by all sources of the user
        /// </summary>
        /// <returns></returns>
        public int TotalSalaryAndIncome()
        {
            return ( _basicDaAmount +  _hraAmount + _bonusCommissionAmount + _otherAllowancesAmount +
                     _businessAmount + _professionAmount + _shortTermCgNormalRatesAmount +_shortTermCg15Amount +
                    _longTermCg10 + _longTermCg20 + _interestSavingsBankAccounts + _interestFixedDeposits + 
                    _otherSources ) ;
        }

    }
}
