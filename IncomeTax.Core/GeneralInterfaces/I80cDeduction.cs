namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface I80cDeduction
    {
        /// <summary>
        /// Equity Linked Saving Scheme deduction
        /// </summary>
        int EquityLinkedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Employee provident fund deduction
        /// </summary>
        int EPFAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Life Insurance deduction
        /// </summary>
        int LifeInsuranceAmount
        {
            get;
            set;
        }


        /// <summary>
        /// Provident Fund Deduction Amount
        /// </summary>
        int ProvidentFundAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Housing Loan Principal Deduction Amount
        /// </summary>
        int HousingLoanPrincipalAmount
        {
            get;
            set;
        }


        /// <summary>
        /// National Pension Scheme Deduction Amount
        /// </summary>
        int NationalPensionSchemeAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Tuition Fees deduction amount
        /// </summary>
        int TuitionFeesAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Others amount
        /// </summary>
        int OthersAmount
        {
            get;
            set;
        }

        int GetAmountUnder80C();
    }
}
