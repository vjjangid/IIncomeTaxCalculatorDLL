namespace IncomeTax.Core.GeneralInterfaces
{
    internal interface IDeductionFoodCoupons
    {
        int FoodCouponsAmount
        {
            get;
            set;
        }

        int GetAmountFoodCoupons();
    }
}
