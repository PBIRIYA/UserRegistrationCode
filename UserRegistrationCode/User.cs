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
        public string email { get; set; }
        private string _regexEmail = "^[A-Za-z0-9]+([._+-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, _regexFirstName);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, _regexLastName);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, _regexEmail);
        }
    }
}
