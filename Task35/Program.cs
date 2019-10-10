using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fstream = File.OpenRead(@"C:\13.txt");
            byte[] array = new byte[fstream.Length];
            fstream.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            Console.WriteLine("Текст из файла: " + textFromFile);
            Console.ReadKey();
        }
    }
}
