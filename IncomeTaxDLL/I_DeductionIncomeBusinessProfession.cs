using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    interface I_DeductionIncomeBusinessProfession
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
