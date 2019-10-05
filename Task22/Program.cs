using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter some string");
            string s = Console.ReadLine();
            s = s.ToUpper();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
