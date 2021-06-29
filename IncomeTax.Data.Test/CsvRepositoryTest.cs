namespace IncomeTax.Data.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvRepositoryTest
    {
        private CsvRepository _mCsvRepository;
        private readonly string _filePath = @"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Test.csv";

        [TestMethod]
        public void CsvRepositoryCreateUserTest()
        {
            //Arrange
            UserDetails user = new UserDetails("123456", "Mahesh", "Mahesh134");                              
            _mCsvRepository = new CsvRepository(_filePath, user);
            _mCsvRepository.Create(user);
            bool expected = true;

            //Act
            bool original = _mCsvRepository.Read(user);

            //Assert
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void CsvRepositoryDeleteUserTest()
        {
            //Arrange
            UserDetails user = new UserDetails("123456", "Mahesh", "Mahesh134");
            _mCsvRepository = new CsvRepository(_filePath, user);
            _mCsvRepository.Delete(user);
            bool expected = false;

            //Act
            bool original = _mCsvRepository.Read(user);

            //Assert
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void CsvRepositoryUpdateUserTest()
        {
            //Arrange
            UserDetails user = new UserDetails("123456", "Mahesh", "Mahesh1345689");
            _mCsvRepository = new CsvRepository(_filePath, user);
            _mCsvRepository.Update(user);
            bool expected = true;

            //Act
            bool original = _mCsvRepository.Read(user);

            //Assert
            Assert.AreEqual(expected, original);
        }
    }
}
