namespace IncomeTax.Data.Test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvWriterTest
    {
        private static string _filePath = @"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Test.csv";

        [TestMethod]
        public void WriteDataWritingTest()
        {
            //Arrange
            UserDetails user = new UserDetails("94606366", "BABU", "@546sdf");
            CsvFileWriter writer = new CsvFileWriter(_filePath);
            writer.WriteRecord(user);
            bool expected = true;

            //Act
            CsvFileReader reader = new CsvFileReader(_filePath);
            HashSet<string> validList = reader.ValidUserHashSet();
            bool original = true;

            //Assert
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void DeleteRecordTest()
        {
            //Arrange
            UserDetails user = new UserDetails("94606366", "BABU", "@546sdf");
            CsvFileWriter writer = new CsvFileWriter(_filePath);
            bool expected = false;

            //Act
            writer.DeleteRecord(user.MobileNumber);
            CsvFileReader reader = new CsvFileReader(_filePath);
            HashSet<string> validList = reader.ValidUserHashSet();
            bool original = validList.Contains(user.MobileNumber);

            //Assert
            Assert.AreEqual(expected, original);
        }
    }
}
