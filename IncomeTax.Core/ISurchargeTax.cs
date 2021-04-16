using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface ISurchargeTax
    {
        //if income is > 50L
        bool Surcharge10Percent { get; }

        //if income is > 1 crore
        bool Surcharge15Percent { get; }

        //if income is > 2 crore
        bool Surcharge25Percent { get; }

        //if income is > 5 crore
        bool Surcharge37Percent { get; }

        int GetSurcharge();


    }
}
