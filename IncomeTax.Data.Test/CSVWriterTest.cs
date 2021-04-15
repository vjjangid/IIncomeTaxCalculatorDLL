using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax.Data;
using System.Collections.Generic;

namespace IncomeTax.Data.Test
{
    [TestClass]
    public class CSVWriterTest
    {
        private static string filePath = @"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Test.csv";


        [TestMethod]
        public void WriteDataWritingTest()
        {

            //Arrange
            UserDetails user = new UserDetails("94606366", "BABU", "@546sdf");
            CsvFileWriter writer = new CsvFileWriter(filePath);
            writer.WriteRecord(user);

            bool expected = true;

            //Act
            CsvFileReader reader = new CsvFileReader(filePath);
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
            CsvFileWriter writer = new CsvFileWriter(filePath);
            bool expected = false;

            //Act
            writer.DeleteRecord(user.MobileNumber);
            CsvFileReader reader = new CsvFileReader(filePath);
            HashSet<string> validList = reader.ValidUserHashSet();
            bool original = validList.Contains(user.MobileNumber);

            //Assert
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void UpdateRecordTest()
        {

        }

    }
}
