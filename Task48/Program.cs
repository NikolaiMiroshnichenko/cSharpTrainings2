using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task48
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            FileInfo fo = new FileInfo(s);
            try
            {
                if (fo.Exists)
                {
                    Console.WriteLine("File Exists");
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Error message");

                throw new FileNotFoundException();

            }

            
        }
    }
}
