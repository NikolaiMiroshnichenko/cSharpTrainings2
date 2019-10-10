using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter name of file on disk C in format \"name.extension\": ");
            string s = Console.ReadLine();
            s = @"C:\" + s;
            FileInfo fileInfo = new FileInfo(s);
            if (fileInfo.Exists)
            {
                Console.WriteLine("File exists");
            }
            else
            {
                throw new FileNotFoundException(); 
            }

            Console.ReadKey();
        }
    }
}
