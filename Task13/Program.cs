using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your naame?");
            string name = Console.ReadLine();
            if (name.Contains("1")|| name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("0"))
            {
                Console.WriteLine("Incorrect name");
            }
            else
            {
                Console.WriteLine("valid name");
            }

            Console.ReadKey();
        }
    }
}
