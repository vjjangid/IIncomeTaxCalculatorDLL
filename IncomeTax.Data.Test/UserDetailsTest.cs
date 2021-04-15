using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax.Data;

namespace IncomeTax.Data.Test
{
    [TestClass]
    public class UserDetailsTest  
    {

        [TestMethod]
        public void UserDetailsEqualityValidTest()
        {
            //--Arrange
            UserDetails user = new UserDetails("8502803874", "Vijay", "Mahindra");
            var expected = true;

            //--Act
            UserDetails user1 = new UserDetails("8502803874", "Vijay", "Mahindra");
            var actual = user.Equals(user1);

            //Assert
            Assert.AreEqual(expected, actual);
             
        }

        [TestMethod]
        public void UserDetailsEqualityInvalidTest()
        {
            //--Arrange
            UserDetails user = new UserDetails("8502803874", "Vijay", "Mahindra");
            var expected = false;

            //--Act
            UserDetails user1 = new UserDetails("8502803874", "Vijay", "Mahindraa");
            var actual = user.Equals(user1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
