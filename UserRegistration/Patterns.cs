using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Patterns
    {
        public static string REGEX_FIRSTNAME= "^[A-Z][a-z]{2,}$";
        public static string REGEX_LASTNAME= "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_FIRSTNAME);
        }
    }
}
