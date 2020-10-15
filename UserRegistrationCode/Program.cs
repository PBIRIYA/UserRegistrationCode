using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace UserRegistrationCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            var user = new User();
            Console.Write("Enter First Name :");
            var firstName = Console.ReadLine();
            if (user.ValidateFirstName(firstName))
                user.firstName = firstName;
            else
                Console.WriteLine("Invalid first name. " +
                    "It should have minimum 3 letters and only first letter as capital");
        }
        public static void AskLastName(User user)
        {
            Console.Write("Enter Last Name :");
            var lastName = Console.ReadLine();
            if (user.ValidateLastName(lastName))
                user.lastName = lastName;
            else
                Console.WriteLine("Invalid Last name. " +
                    "It should have minimum 3 letters and only first letter as capital");
        }
        public static void AskEmail(User user)
        {
            Console.Write("Enter Email :");
            var email = Console.ReadLine();
            if (user.ValidateEmail(email))
                user.email = email;
            else
                Console.WriteLine("Invalid email. " +
                    "It should be in the correct format E.g. abc.xyz@bl.co.in");
        }
        public static void AskMobileNumber(User user)
        {
            Console.Write("Enter Mobile Number : ");
            var mobileNumber = Console.ReadLine();
            if (user.ValidateMobileNumber(mobileNumber))
                user.mobileNumber = mobileNumber;
            else
                Console.WriteLine("Invalid Moobile Number. " +
                    "It should be in the correct format E.g. 91 9919819801");
        }
        public static void AskPassword(User user)
        {
            Console.Write("Enter Password : ");
            var password = Console.ReadLine();
            if (user.ValidatePassword(password))
                user.password = password;
            else
                Console.WriteLine("Invalid Password. " +
                    "It should have Minimum 8 characters, atleast 1 Upper Case, atleast 1 number and exactly 1 special character");
        }
        public static void CheckEmails(string allEmails)
        {
            var user = new User();
            string[] emails = allEmails.Split(' ');
            foreach (var email in emails)
            {
                Console.Write(email + " : ");
                if (user.ValidateEmail(email))
                    Console.Write("Valid");
                else
                    Console.Write("Invalid");
                Console.WriteLine();
            }
        }
    }
}
