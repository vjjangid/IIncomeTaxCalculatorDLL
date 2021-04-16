using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IDeductionIncomeBusinessProfession
    {
        int BusinessAmount
        {
            get;
            set;
        }

        int ProfessionAmount
        {
            get;
            set;
        }
    }
}
