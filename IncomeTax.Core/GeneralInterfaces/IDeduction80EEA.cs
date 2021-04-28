using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    interface IDeduction80EEA
    {
        int IDeduction80EEA_Amount
        {
            get;
            set;
        }

        int GetAmountUnder80EEA();
    }
}
