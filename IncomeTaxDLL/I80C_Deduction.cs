using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    interface I80C_Deduction
    {

        /// <summary>
        /// Equity Linked Saving Scheme deduction
        /// </summary>
        double I80C_EquityLinkedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Employee provident fund deduction
        /// </summary>
        double I80C_EPFAmount
        {
            get;
            set;
        }


        /// <summary>
        /// Life Insurance deduction
        /// </summary>
        double I80C_LifeInsuranceAmount
        {
            get;
            set;
        }


        /// <summary>
        /// Provident Fund Deduction Amount
        /// </summary>
        double I80C_ProvidentFundAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Housing Loan Principal Deduction Amount
        /// </summary>
        double I80C_HousingLoanPrincipalAmount
        {
            get;
            set;
        }


        /// <summary>
        /// National Pension Scheme Deduction Amount
        /// </summary>
        double I80C_NationalPensionSchemeAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Tuition Fees deduction amount
        /// </summary>
        double I80C_TuitionFeesAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Others amount
        /// </summary>
        double I80C_OthersAmount
        {
            get;
            set;
        }
    }
}
