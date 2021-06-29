namespace IncomeTaxTest.Unit
{
    using IncomeTax.Core.OldTaxRegimeStrategy;
    using NUnit.Framework;

    [TestFixture]
    public class SuperSeniorTaxSlabTest
    {
        private SuperSeniorTaxSlab m_SuperSeniorTaxSlab;

        [OneTimeSetUp]
        public void Setup()
        {
            m_SuperSeniorTaxSlab = new SuperSeniorTaxSlab();
        }



        [Test]
        public void Given_Negative_Tax_Amount_When_CalculateTax_Invoked_Then_Returns_Zero()
        {
            //Arrange
            const int expected = 0;

            //Act
            var actual = (int)m_SuperSeniorTaxSlab.CalculateTax(-1523);

            //Assert
            Assert.AreEqual(expected, actual, "Not able to handle the negative amount");
        }

        /// <summary>
        /// Check the Super Senior category perosn having income upto 10L
        /// </summary>
        [Test]
        public void Given_GeneralSlab20PercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Returns_TaxAmount()
        {
            //Arrange
            const int expected = 100000;

            //Act
            var actual = (int)m_SuperSeniorTaxSlab.CalculateTax(1000000);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Super Senior category person having income more then 10L
        /// </summary>
        [Test]
        public void Given_GeneralSlab30PercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Return_TaxAmount()
        {
            //Arrange
            const int expected = 100000 + 60000;

            //Act
            var actual = (int)m_SuperSeniorTaxSlab.CalculateTax(1200000);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
