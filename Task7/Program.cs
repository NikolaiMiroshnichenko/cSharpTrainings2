using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter some date in format day.month.year");
            try
            {
                string someData = Console.ReadLine();
                DateTime dateTime = new DateTime();
                dateTime = Convert.ToDateTime(someData);
                Console.WriteLine(dateTime.ToShortDateString());
            }
            catch
            {
                Console.WriteLine("you enter wrong data");
            }
            Console.ReadKey();
        }
    }
}
