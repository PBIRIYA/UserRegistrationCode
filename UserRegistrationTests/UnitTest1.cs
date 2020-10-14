using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using UserRegistrationCode;
namespace UserRegistrationTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void VerifyFirstName_StartsWith_CapitalOrNot()
        {
            User user = new User();
            var firstName = "Priya";
            var result = user.ValidateFirstName(firstName); ;
            Assert.IsTrue(result);
        }
    }
}