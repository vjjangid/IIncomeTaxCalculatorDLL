namespace IncomeTax.Data.Test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvReaderTest
    {
        private readonly CsvFileReader _reader = new CsvFileReader(@"C:\Users\z0049n3x\source\repos\IIncomeTaxCalculatorDLL\IncomeTax.Data.Test\TestResources\Empty.csv");

        /// <summary>
        /// Test for reading user list for empty file
        /// </summary>
        [TestMethod]
        public void CsvReaderValidUserListTestEmptyFile()
        {
            //--Arrange
            HashSet<string> readerList = _reader.ValidUserHashSet();
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
            HashSet<string> readerList = _reader.ValidUserHashSet();
            int expected = 2;
 
            //--Act
            int actual = readerList.Count;

            //--Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
