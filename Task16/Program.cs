using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string s = Console.ReadLine();
            string pattern = @"(\d+\.{1}\d+){1}";
            if (Regex.IsMatch(s, pattern))
            {
                Console.WriteLine("Float number");
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }
            Console.ReadKey();
        }
    }
}
