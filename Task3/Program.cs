using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime someData = new DateTime(2008,09,01);
            Console.WriteLine(someData.DayOfWeek);
            Console.ReadKey();
        }
    }
}
