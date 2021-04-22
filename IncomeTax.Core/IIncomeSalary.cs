using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    interface IIncomeSalary
    {
        int BasicDAAmount
        {
            get;
            set;
        }

        int HRA_Amount
        {
            get;
            set;
        }

        int BonusCommissionAmount
        {
            get;
            set;
        }

        int OtherAllowancesAmount
        {
            get;
            set;
        }

    }
}
