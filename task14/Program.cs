using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string s = Console.ReadLine();
            string pattern = @" \d{2} ";
            if (Regex.IsMatch(s, pattern))
            {
                Console.WriteLine("Ok");
            }
            Console.ReadKey();
        }
    }
}
