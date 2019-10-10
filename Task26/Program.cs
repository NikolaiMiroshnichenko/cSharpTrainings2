using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] splitedString = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int c = 1;
            for (int i = 0; i < splitedString.Length; i++)
            {
                c = c + 1;
            }
            Console.WriteLine(c-1);

            Console.ReadKey();
        }
    }
}
