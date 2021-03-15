using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IDeductionStandard
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
