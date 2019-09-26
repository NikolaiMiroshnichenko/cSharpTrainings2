using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some calendar day");
            if (int.TryParse(Console.ReadLine(), out int day) && day < 32 && day > 0)
            {
               
            }
            else
            {
                Console.WriteLine("You enter wrong day");
            }
            Console.WriteLine("Enter some calendar month");
            if (int.TryParse(Console.ReadLine(), out int month) && month < 13 && month > 0)
            {
            }
            else
            {
                Console.WriteLine("You enter wrong month");
            }
            Console.WriteLine("Enter some year");
            if (int.TryParse(Console.ReadLine(), out int year) && day < 10000 && day > 0)
            {
            }
            else
            {
                Console.WriteLine("You enter wrong year");
            }

            string someStringData = ($"{day}.{month}.{year}");
            DateTime someData = new DateTime();
            someData = Convert.ToDateTime(someStringData);
            Console.WriteLine(someData.ToLongDateString());

            
            Console.ReadKey();
        }
    }
}
