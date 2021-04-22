using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    interface IDeductionFoodCoupons
    {
        int FoodCouponsAmount
        {
            get;
            set;
        }

        int GetAmountFoodCoupons();
    }
}
