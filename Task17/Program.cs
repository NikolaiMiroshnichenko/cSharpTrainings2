using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string s = Console.ReadLine();
            Console.WriteLine(s.Count(Char.IsPunctuation));
            Console.ReadKey();
        }
    }
}
