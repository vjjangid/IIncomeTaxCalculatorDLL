using IncomeTax.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxTest
{
    [TestClass]
    public class OldTaxRegimeTest
    {
        [TestMethod]
        public void GetSurcharge_GeneralTaxableIncomeGiven_ShouldReturnIntTax()
        {
            OldTaxRegime oldTaxRegime = new OldTaxRegime(20000000, 5000, 6333, true);
            int expected = 3000000;
            int original = oldTaxRegime.GetSurcharge();
            Assert.AreEqual(expected, original);

        }
    }
}
