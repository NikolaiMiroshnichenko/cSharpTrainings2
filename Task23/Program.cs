using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            string pattern = @"((?=!@#$%^&*)(?=.*[a - z])(?=.*[A - Z]).{ 8,})";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Valid password");
                }
            else
            {
                Console.WriteLine("Incorrect password");
            }

            Console.ReadKey();
        }
    }
}
