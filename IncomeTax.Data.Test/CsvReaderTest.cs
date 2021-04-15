using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax.Data;
using System.Collections.Generic;

namespace IncomeTax.Data.Test
{
    [TestClass]
    public class CsvReaderTest
    {


        /// <summary>
        /// Test for reading user list for empty file
        /// </summary>
        [TestMethod]
        public void CsvReaderValidUserListTestEmptyFile()
        {
            //--Arrange
            CsvFileReader reader = new CsvFileReader(@"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Empty.csv");
            HashSet<string> readerList = reader.ValidUserHashSet();

            int expected = 0;

            //--Act

            int actual = readerList.Count;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Test for reading user list for not empty file
        /// </summary>
        [TestMethod]
        public void CsvReaderValidUserListTestContainsData()
        {
            //--Arrange
            CsvFileReader reader = new CsvFileReader(@"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Test.csv");
            HashSet<string> readerList = reader.ValidUserHashSet();

            int expected = 2;
 
            //--Act

            int actual = readerList.Count;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
