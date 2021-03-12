using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IIncomeOtherSources
    {

        double InterestSavingsBankAccounts
        {
            get;
            set;
        }

        double InterestFixedDeposits
        {
            get;
            set;
        }

        double OtherSources
        {
            get;
            set;
        }
    }
}
