using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax;

namespace IncomeTaxTest
{
    [TestClass]
    public class UserTest
    {
        /// <summary>
        /// To check whether the full name is working correctly or not
        /// </summary>
        [TestMethod]
        public void UserNameTestValid()
        {
            // -- Arrange
            User user = new User();
            user.FirstName = "Mahesh";
            user.LastName = "Almond";

            string expected = "Mahesh Almond";

            // -- Act

            string actual = user.FullUserName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// IF firstname is not given
        /// </summary>
        [TestMethod]
        public void UserNameFirstNameEmpty()
        {

            // --Arrange

            User user = new User();
            user.LastName = "Jangid";

            string expected = "Jangid";

            //--Act
            string actual = user.FullUserName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If last name is not given
        /// </summary>
        [TestMethod]
        public void UserNameLastNameEmpty()
        {

            // --Arrange

            User user = new User();
            user.FirstName = "Mahesh";

            string expected = "Mahesh";

            //--Act
            string actual = user.FullUserName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserNameFullNameEmpty()
        {
            // -- Arrange
            User user = new User();
            

            string expected = "";

            // -- Act

            string actual = user.FullUserName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// User Age Category
        /// </summary>
        [TestMethod]
        public void UserAgeCategoryTest()
        {
            // --Arrange
            User user = new User();
            user.DOB = new DateTime(1997, 08, 26);

            AgeCategory expected = AgeCategory.General;

            // --Act
            AgeCategory actual = user.UserAgeClass;

            // --Arrange
            Assert.AreEqual(expected, actual);

        }
    }
}
