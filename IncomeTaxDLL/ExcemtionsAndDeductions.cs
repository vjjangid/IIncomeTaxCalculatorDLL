using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    public class ExcemtionsAndDeductions : IDeductionStandard , I80CCD2Deduction , I80C_Deduction 
    {

        #region Properties

        private double _standardDeductionAmount;
        private double _I80CCD2DeductionAmount;
        private double _I80CEquityLinkedAmount;
        private double _I80C_EPFAmount;
        private double _I80C_LiferInsuranceAmount;
        private double _I80C_ProvidentFundAmount;
        private double _I80C_HousingLoanPrincipalAmount;
        private double _I80C_NationalPensionSchemeAmount;
        private double _I80C_TuitionFeesAmount;
        private double _I80C_OthersAmount;

        #endregion

        #region Methods

        /// <summary>
        /// Taking Standard deduction Amount
        /// </summary>
        public double StandardDeductionAmount 
        { 
            get
            {
                return _standardDeductionAmount;
            }
            set
            {
                _standardDeductionAmount = value;
            }
        }


        /// <summary>
        /// Taking Deduction Amount under 80CCD
        /// </summary>
        public double I80CCD2DeductionAmount 
        { 
            get
            {
                return _I80CCD2DeductionAmount;
            }
            set
            {
                _I80CCD2DeductionAmount = value;
            }
        }


        /// <summary>
        /// Excemptions under 80 C for equity linked funds
        /// </summary>
        public double I80C_EquityLinkedAmount 
        { 
            get
            {
                return _I80CEquityLinkedAmount;
            }
            set
            {
                _I80CEquityLinkedAmount = value;
            }
        }

        /// <summary>
        /// Excemptions under 80C for Employee Provident Fund amount
        /// </summary>
        public double I80C_EPFAmount
        {
            get
            {
                return _I80C_EPFAmount;
            }
            set
            {
                _I80C_EPFAmount = value;
            }
        }

        /// <summary>
        /// Excemptions under 80C for Life Insurance 
        /// </summary>
        public double I80C_LifeInsuranceAmount 
        {
            get 
            {
                return _I80C_LiferInsuranceAmount;
            }
            set
            {
                _I80C_LiferInsuranceAmount = value;
            }
        }

        /// <summary>
        /// Exemption under 80C for Provident Fund
        /// </summary>
        public double I80C_ProvidentFundAmount 
        {
            get
            {
                return _I80C_ProvidentFundAmount;
            }
            set
            {
                _I80C_ProvidentFundAmount = value;
            }
        }

        /// <summary>
        /// Excemption under 80C for Housing Loan Principal Amount
        /// </summary>
        public double I80C_HousingLoanPrincipalAmount 
        {
            get
            {
                return _I80C_HousingLoanPrincipalAmount;
            }
            set
            {
                _I80C_HousingLoanPrincipalAmount = value;
            }
        }

        /// <summary>
        /// Excemption under 80C for National Pension Scheme Amount
        /// </summary>
        public double I80C_NationalPensionSchemeAmount 
        {
            get
            {
                return _I80C_NationalPensionSchemeAmount;
            }
            set
            {
                _I80C_NationalPensionSchemeAmount = value;
            }
        }

        /// <summary>
        /// Excemption under 80C for Tuition Amount
        /// </summary>
        public double I80C_TuitionFeesAmount 
        {
            get
            {
                return _I80C_TuitionFeesAmount;
            }
            set
            {
                _I80C_TuitionFeesAmount = value;
            }
        }

        /// <summary>
        /// Excmeption under 80C for Others Expenses
        /// </summary>
        public double I80C_OthersAmount 
        { 
            get
            {
                return _I80C_OthersAmount;
            }
            set
            {
                _I80C_OthersAmount = value;
            }
        }

        #endregion
    }
}
