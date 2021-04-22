using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    interface IDeductionOthers
    {
        int OtherDeductionAmount
        {
            get;
            set;
        }
    }
}
