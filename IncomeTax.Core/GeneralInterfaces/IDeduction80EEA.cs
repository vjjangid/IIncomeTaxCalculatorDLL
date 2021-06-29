namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IDeduction80EEA
    {
        int IDeduction80eeaAmount
        {
            get;
            set;
        }

        int GetAmountUnder80EEA();
    }
}
