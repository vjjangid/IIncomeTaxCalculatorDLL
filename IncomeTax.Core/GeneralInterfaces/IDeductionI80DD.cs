namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IDeductionI80DD
    {
        int Deduction80DDAmount
        {
            get;
            set;
        }

        int GetAmountUnder80DD();
    }
}
