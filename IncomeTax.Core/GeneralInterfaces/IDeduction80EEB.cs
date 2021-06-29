namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IDeduction80EEB
    {
        int Deduction80EEBAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Amount that can be exempted under 80EEB
        /// </summary>
        /// <returns></returns>
        int GetAmountUnder80EEB();
    }
}
