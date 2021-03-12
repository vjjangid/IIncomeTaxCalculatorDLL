using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    interface IIncomeSalary
    {
        double BasicDAAmount
        {
            get;
            set;
        }

        double HRA_Amount
        {
            get;
            set;
        }

        double BonusCommissionAmount
        {
            get;
            set;
        }

        double OtherAllowancesAmount
        {
            get;
            set;
        }

    }
}
