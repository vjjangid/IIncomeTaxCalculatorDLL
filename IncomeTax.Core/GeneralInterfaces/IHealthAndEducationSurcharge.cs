using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    /// <summary>
    /// Surcharge is applicable on whole calculated tax
    /// </summary>
    interface IHealthAndEducationSurcharge
    {
        int GetHelathSurcharge();
    }
}
