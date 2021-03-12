using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IIncomeCapitalGains
    {
        double ShortTermCGNormalRates
        {
            get;
            set;
        }

        double ShortTermCG15
        {
            get;
            set;
        }

        double LongTermCG10
        {
            get;
            set;
        }

        double LongTermCG20
        {
            get;
            set;
        }
    }
}
