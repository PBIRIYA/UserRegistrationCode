using System;
using System.Collections.Generic;
using System.Text;
namespace UserRegistrationCode
{
    public class UserException : Exception
    {
        public enum error { Invalid_Name, Invalid_Email, Invalid_Password, Invalid_Mobile };
        public error errorType;
        public UserException(error error, string message) : base(message)
        {
            errorType = error;
        }
    }
}