using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IDeductionIncomeBusinessProfession
    {
        double BusinessAmount
        {
            get;
            set;
        }

        double ProfessionAmount
        {
            get;
            set;
        }
    }
}
