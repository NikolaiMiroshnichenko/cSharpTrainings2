using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime someData = new DateTime();
            someData = DateTime.Now;
            someData = someData.AddMonths(3).AddDays(14);
            Console.WriteLine($"{someData}, {someData.DayOfWeek}");
            Console.ReadKey();
        }
    }
}
