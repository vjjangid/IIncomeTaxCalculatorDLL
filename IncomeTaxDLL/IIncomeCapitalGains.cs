using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IIncomeCapitalGains
    {
        int ShortTermCGNormalRates
        {
            get;
            set;
        }

        int ShortTermCG15
        {
            get;
            set;
        }

        int LongTermCG10
        {
            get;
            set;
        }

        int LongTermCG20
        {
            get;
            set;
        }
    }
}
