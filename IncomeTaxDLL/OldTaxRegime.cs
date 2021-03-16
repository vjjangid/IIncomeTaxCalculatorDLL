using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    /// <summary>
    /// Tax calculation based on old tax regime
    /// What do I need here
    /// ==> Exemption Deduction are present here --> Inherits Exemption and Deduction class
    /// ==> After exempting Deductions I get taxable income 
    /// ==> On this taxable income calculate Tax --> Use OldTaxRegimeSlab class 
    /// ==> Calculate the surcharge on total income --> Implements ISurcharge interface
    /// ==> Calculate the health surcharge on total tax --> Implements the Health Surcharge interface
    /// </summary>
    public class OldTaxRegime : ExemptionsAndDeductions, ISurchargeTax, IHealthAndEducationSurcharge
    {
        public bool Surcharge10Percent => throw new NotImplementedException();

        public bool Surcharge15Percent => throw new NotImplementedException();

        public bool Surcharge25Percent => throw new NotImplementedException();

        public bool Surcharge37Percent => throw new NotImplementedException();

        public int GetHelathSurcharge()
        {
            throw new NotImplementedException();
        }

        public int GetSurcharge()
        {
            throw new NotImplementedException();
        }
    }
}
