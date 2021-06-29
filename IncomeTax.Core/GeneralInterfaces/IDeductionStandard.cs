namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IDeductionStandard
    {
        int StandardDeductionAmount
        {
            get;
            set;
        }

        /// <summary>
        /// standard deduction amount is always there every year for
        /// which every citizen is eligible
        /// </summary>
        /// <returns></returns>
        int GetStandardDeductionAmount();
    }
}
