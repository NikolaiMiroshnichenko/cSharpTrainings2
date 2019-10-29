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
            string[] splitedString = textFromFile.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int c = 0;
            for (int i = 0; i < splitedString.Length; i++)
            {
                c++;
            }
            Console.WriteLine("Count of words is : " + c);

            char[] charsArray = textFromFile.ToCharArray();

            int g = 0;
            for (int i = 1; i < charsArray.Length; i++)
            {
                if ((charsArray[i] == ' ')&&(charsArray[i - 1] == '.'))
                { 
                    g++;
                }
            }
            g = g + 1;
            Console.WriteLine("Count of sentences is : " + g);

            Console.ReadKey();
        }
    }
}
