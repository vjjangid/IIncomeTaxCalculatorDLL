using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IDeductionSection24B
    {
        int IDeductionSection_24BAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Amount for which the candidated us eligible under this section
        /// </summary>
        /// <returns></returns>
        int GetAmountUnderSection24B();
    }
}
