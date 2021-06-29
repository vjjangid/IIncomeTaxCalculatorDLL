namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IDeductionIncomeBusinessProfession
    {
        int BusinessAmount
        {
            get;
            set;
        }

        int ProfessionAmount
        {
            get;
            set;
        }
    }
}
