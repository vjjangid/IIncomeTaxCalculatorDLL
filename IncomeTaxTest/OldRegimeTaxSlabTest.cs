using Microsoft.VisualStudio.TestTools.UnitTesting;
using IncomeTax.Core;

namespace IncomeTaxTest
{
    /// <summary>
    /// Testing the slab rates of tax
    /// </summary>
    [TestClass]
    public class OldRegimeTaxSlabTest
    {

        [TestMethod]
        public void CalculateTax_IncomeGiven_ShouldReturnIntTax()
        {
            OldRegimeTaxSlab oldRegimeTaxSlab = new OldRegimeTaxSlab();
            int expected = 0;

            int original = oldRegimeTaxSlab.CalculateTax(AgeCategory.General, 200000);

            Assert.AreEqual(expected, original);
        }
    }
}
