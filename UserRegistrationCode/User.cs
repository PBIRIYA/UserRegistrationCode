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
        public string mobileNumber { get; set; }
        private string _regexMobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public string password { get; set; }
        private string _regexPassword = "^(?=.*[A-Z])[\\S]{8,}$";
        string _regex = "";
        private bool Validate(string str, string regex)
        {
            Regex rgxObj = new Regex(_regex);
            return rgxObj.IsMatch(str);
        }
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
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, _regexMobileNumber);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, _regexPassword);
        }
        public void VerifiedEmailList()
        {
            List<string> emailList = new List<string>();
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@yahoo.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");
            emailList.Add("abc");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abc@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");
            emailList.Add("abc@gmail.com.1a");
            emailList.Add("abc@gmail.com.aa.au");

            _regex = "^[a-z0-9-+]+([.][a-z0-9+-]+)?@[a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";
            foreach (string email in emailList)
            {
                if (Validate(email, _regex))
                    Console.WriteLine(email + "- VALID");
                else
                    Console.WriteLine(email + "- INVALID");
            }
        }
    }
}
