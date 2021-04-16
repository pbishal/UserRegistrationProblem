using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Patterns
    {
        public static string REGEX_FIRSTNAME= "^[A-Z][a-z]{3,}$";
        public static string REGEX_LASTNAME= "^[A-Z][a-z]{3,}$";
        public static string REGEX_MOBILENUMBER = "^[0-9]{2}[ ][0-9]{10}$";
        public static string REGEX_EMAIL = @"^[a-z]{3,}\.[a-z0-9]{2,}\@[a-z]{2,}\.[a-z]{2}\.[a-z]{2}";
        public static string REGEX_PASSWORD = "[A-Za-z]{8}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, REGEX_MOBILENUMBER);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
