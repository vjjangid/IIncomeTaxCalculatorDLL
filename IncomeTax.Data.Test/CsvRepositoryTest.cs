using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IncomeTax.Data.Test
{
    [TestClass]
    public class CsvRepositoryTest
    {
        private CSVRepository csvRepository;
        private readonly string _filePath = @"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Test.csv";

        [TestMethod]
        public void CsvRepositoryCreateUserTest()
        {
            //Arrange
            UserDetails user = new UserDetails("123456", "Mahesh", "Mahesh134");
                               
            csvRepository = new CSVRepository(_filePath, user);
            csvRepository.Create(user);

            bool expected = true;

            //Act
            bool original = csvRepository.Read(user);

            //Assert
            Assert.AreEqual(expected, original);

        }

        [TestMethod]
        public void CsvRepositoryDeleteUserTest()
        {
            //Arrange
            UserDetails user = new UserDetails("123456", "Mahesh", "Mahesh134");

            csvRepository = new CSVRepository(_filePath, user);
            csvRepository.Delete(user);

            bool expected = false;

            //Act
            bool original = csvRepository.Read(user);

            //Assert
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void CsvRepositoryUpdateUserTest()
        {
            //Arrange
            UserDetails user = new UserDetails("123456", "Mahesh", "Mahesh1345689");

            csvRepository = new CSVRepository(_filePath, user);
            csvRepository.Update(user);

            bool expected = true;

            //Act
            bool original = csvRepository.Read(user);

            //Assert
            Assert.AreEqual(expected, original);
        }
    }
}
