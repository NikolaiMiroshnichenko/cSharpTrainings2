using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            Console.WriteLine(d.AddHours(24).AddMinutes(5));
            Console.ReadKey();
        }
    }
}
