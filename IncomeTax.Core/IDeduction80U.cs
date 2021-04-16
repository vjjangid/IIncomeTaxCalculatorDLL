using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IDeduction80U
    {
        int IDeduction80U_Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Amount that can be deducted under 80U
        /// </summary>
        /// <returns></returns>
        int GetAmountUnder80U();
    }
}
