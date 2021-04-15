using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();

            Console.WriteLine(patterns.ValidateFirstName("Bishal"));
            Console.WriteLine("enter the first name:");
            //string firstname = Console.ReadLine();

        }
    }
}
