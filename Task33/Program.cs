using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"C:\13.txt";
            FileInfo fileInfo = new FileInfo(s);
            if (fileInfo.Length == 0)
            {
                Console.WriteLine("File is empty");
            }
            else
            {
                Console.WriteLine("File isn't empty");
            }

            Console.ReadKey();
        }
    }
}
