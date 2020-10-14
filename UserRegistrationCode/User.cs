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
        public string lastName { get; set; }
        private string _regexLastName = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, _regexFirstName);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, _regexLastName);
        }
    }
}
