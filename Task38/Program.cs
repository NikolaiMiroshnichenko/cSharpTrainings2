using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = File.OpenRead(@"C:\2.txt");
            byte[] Array = new byte[file.Length];
            file.Read(Array, 0, Array.Length);

            FileStream file2 = new FileStream(@"C:\3.txt", FileMode.OpenOrCreate);
            file2.Write(Array, 0, Array.Length);
            
        }
    }
}
