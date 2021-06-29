namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IIncomeCapitalGains
    {
        int ShortTermCGNormalRates
        {
            get;
            set;
        }

        int ShortTermCG15
        {
            get;
            set;
        }

        int LongTermCG10
        {
            get;
            set;
        }

        int LongTermCG20
        {
            get;
            set;
        }
    }
}
