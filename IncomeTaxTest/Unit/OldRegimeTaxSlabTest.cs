namespace IncomeTaxTest.Unit
{
    using IncomeTax.Core;
    using IncomeTax.Core.OldTaxRegimeStrategy;
    using NUnit.Framework;

    /// <summary>
    /// Testing the slab rates of tax
    /// </summary>
    [TestFixture]
    public class OldRegimeTaxSlabTest
    {
        [Test]
        public void CalculateTax_IncomeGiven_ShouldReturnIntTax()
        {
            //Arrange
            const int expected = 0;
            var oldRegimeTaxSlab = new OldRegimeTaxSlab();
            
            //Act
            var original = oldRegimeTaxSlab.CalculateTax(AgeCategory.General, 200000);

            //Assert
            Assert.AreEqual(expected, original);
        }
    }
}
