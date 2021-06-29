namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IIncomeSalary
    {
        int BasicDAAmount
        {
            get;
            set;
        }

        int HRA_Amount
        {
            get;
            set;
        }

        int BonusCommissionAmount
        {
            get;
            set;
        }

        int OtherAllowancesAmount
        {
            get;
            set;
        }

    }
}
