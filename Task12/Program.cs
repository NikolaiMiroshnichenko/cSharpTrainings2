using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateString = "31-08-2019";

            var result = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(result.ToString("yy-MMM-dd ddd hh:MM:ss"));

            Console.ReadKey();
        }
    }
}
