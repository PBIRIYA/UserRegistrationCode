using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationCode
{
    public class User
    {
        public string firstName { get; set; }
        private string _regexFirstName = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, _regexFirstName);
        }
    }
}
