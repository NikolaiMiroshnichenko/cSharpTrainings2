using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasl24
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your email");
            string s = Console.ReadLine();
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(s, pattern))
            {
                Console.WriteLine("Valid password");

            }
            else
            {
                Console.WriteLine("Invalid password");
            }

            Console.ReadKey();
        }
    }
}
