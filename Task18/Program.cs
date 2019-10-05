using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            string s = Console.ReadLine();
           string result = s.Replace(" ", "_");
             
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
