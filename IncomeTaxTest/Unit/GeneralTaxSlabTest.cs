namespace IncomeTaxTest.Unit
{
    using IncomeTax.Core.OldTaxRegimeStrategy;
    using NUnit.Framework;

    [TestFixture]
    public class GeneralTaxSlabTest
    {
        private GeneralTaxSlab m_GeneralTaxSlab;

        [OneTimeSetUp]
        public void Init()
        {
            m_GeneralTaxSlab = new GeneralTaxSlab();
        }

        [Test]
        public void Given_Negative_Tax_Amount_When_CalculateTax_Invoked_Then_Returns_Zero()
        {
            //Arrange
            const int expected = 0;
            
            //Act
            var actual = (int)m_GeneralTaxSlab.CalculateTax(-1523);

            //Assert
            Assert.AreEqual(expected,actual, "Not able to handle the negative amount");
        }

        /// <summary>
        /// General category salary up-to 5Lakh
        /// </summary>
        [Test]
        public void Given_FivePercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Returns_TaxAmount()
        {
            //Arrange
            const int expected = 12500;

            //Act
            var actual = (int)m_GeneralTaxSlab.CalculateTax(500000);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// General category salary till 10Lakh
        /// </summary>
        [Test]
        public void Given_GeneralSlab20PercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Returns_TaxAmount()
        {
            //Arrange
            const int expected = 12500 + 100000;

            //Act
            var actual = (int)m_GeneralTaxSlab.CalculateTax(1000000);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// General category salary after 10Lakh
        /// </summary>
        [Test]
        public void Given_GeneralSlab30PercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Return_TaxAmount()
        {
            //Arrange
            const int expected = 12500 + 100000 + 60000;

            //Act
            var actual = (int)m_GeneralTaxSlab.CalculateTax(1200000);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
