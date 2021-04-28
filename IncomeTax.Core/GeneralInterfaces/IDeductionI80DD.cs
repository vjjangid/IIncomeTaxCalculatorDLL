using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    interface IDeductionI80DD
    {
        int Deduction80DDAmount
        {
            get;
            set;
        }

        int GetAmountUnder80DD();
    }
}
