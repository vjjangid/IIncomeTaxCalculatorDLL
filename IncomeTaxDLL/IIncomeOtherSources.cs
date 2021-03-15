using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IIncomeOtherSources
    {

        int InterestSavingsBankAccounts
        {
            get;
            set;
        }

        int InterestFixedDeposits
        {
            get;
            set;
        }

        int OtherSources
        {
            get;
            set;
        }
    }
}
