using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    interface IDateInfo
    {
        public string nowData();
    }

    class DataVision : IDateInfo
    {
        public string  nowData()
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
             string dateTimeString  = dateTime.ToLongDateString();
            return dateTimeString;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DataVision dv = new DataVision();
           Console.WriteLine( dv.nowData());
            Console.ReadKey();
        }
    }
}
