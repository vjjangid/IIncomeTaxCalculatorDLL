namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IIncomeOtherSources
    {

        int InterestSavingsBankAccounts
        {
            get;
            set;
        }

        int InterestFixedDeposits
        {
            get;
            set;
        }

        int OtherSources
        {
            get;
            set;
        }
    }
}
