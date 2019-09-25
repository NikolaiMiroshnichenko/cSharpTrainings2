using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowData = new DateTime();
            nowData = DateTime.Now;
            nowData = nowData.AddDays(3);
            Console.WriteLine($"{nowData}, {nowData.DayOfWeek}");

            Console.ReadKey();
        }
    }
}
