using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");
            Regex regex = new Regex(@"\s+");
            string target = Console.ReadLine();
            string replacer = " ";
            Console.WriteLine(regex.Replace(target, replacer));
            Console.ReadKey();
        }
    }
}
