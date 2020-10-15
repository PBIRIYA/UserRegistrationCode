using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [TestMethod]
        public void VerifyLastName_StartsWith_CapitalOrNot()
        {
            User user = new User();
            var lastName = "Biriya";
            var result = user.ValidateLastName(lastName); ;
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("jrm@gmail.com")]
        [DataRow("jrm.cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in")]
        [DataRow("jrm100@gmail.com")]
        [DataRow("jrm-nit@1mg.co.in")]
        public void TestEmailValidation_ValidEmails(string email)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 6231230127")]
        public void TestPhNumberValidation_ValidNumbers(string phNum)
        {
            //Arrange
            User user = new User();
            bool expected = true;
            //Act
            bool actual = user.ValidateMobileNumber(phNum);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Had2Te#t")]
        [DataRow("had2T3stP@ss")]
        [DataRow("T3STP@SS")]
        public void Test_ValidPasswords(string pass)
        {
            //Arrange
            User user = new User();
            bool expected = true;
            //Act
            bool actual = user.ValidatePassword(pass);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Hd2T#t")] //less than 8 char
        [DataRow("had2testPass")] //no special char
        [DataRow("TestP@ss")] //no number
        [DataRow("t3stp@ss")] //no upper case
        [DataRow("T#stP@ss5")] //more than 1 special case
        public void TestPasswordValidation_InvalidPasswords(string pass)
        {
            //Arrange
            User user = new User();
            string expected = "Password needs to have min 8 characters, at least 1 upper case character, at least 1 numeric value, exactly 1 special character";
            string actual;
            //Act
            try
            {
                actual = user.ValidatePassword(pass).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}