using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    interface IDateInfo
    {
        void viewData(DateTime d, out string stringData)
        {
            d = DateTime.Now;
            stringData = d.ToShortDateString();
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
        }
    }
}
