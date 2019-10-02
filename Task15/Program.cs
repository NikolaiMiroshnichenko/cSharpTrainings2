using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number");
            string number = Console.ReadLine();
            string pattern = @"\d{3}-\d{2}-\d{2}";
            if (Regex.IsMatch(number, pattern))
            {
                Console.WriteLine("Number is valid");
            }
            Console.ReadKey();
        }
    }
}
