using IncomeTax.Core;
using IncomeTax.Data;
using NUnit.Framework;
using Rhino.Mocks;

namespace IncomeTaxTest
{
    [TestFixture]
    internal class UserRepositoryTest
    {
        [Test]
        public void given_when_then()
        {
            //Assert
            UserDetails user = new UserDetails("8502803874", "John", "12344");
            var mockUserRepository = MockRepository.GenerateMock<IUserRepository>();
            mockUserRepository.Stub(dao => dao.ValidateUser(user)).Return(true);

            //Act
            UserRepository userRepository = new UserRepository();
            var check = userRepository.IsValidUser(user);

            //Assert
            Assert.AreEqual(true, check);
        }
    }
}
