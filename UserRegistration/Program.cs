using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Welcome to User Registration Problem");
=======
            Patterns patterns = new Patterns();
            //Console.WriteLine("enter the first name:");
            //Console.WriteLine(patterns.ValidateFirstName(Console.ReadLine()));

            //Console.WriteLine("enter the last name:");
            //Console.WriteLine(patterns.ValidateFirstName(Console.ReadLine()));
>>>>>>> UC9_AllEmailValidation

            //Console.WriteLine("enter the mobile number:");
            //Console.WriteLine(patterns.ValidateMobileNumber(Console.ReadLine()));

            Console.WriteLine("enter the email:");
            Console.WriteLine(patterns.ValidateEmail(Console.ReadLine()));

            //Console.WriteLine("enter the password:");
            //Console.WriteLine(patterns.ValidatePassword(Console.ReadLine()));
        }
    }
}
