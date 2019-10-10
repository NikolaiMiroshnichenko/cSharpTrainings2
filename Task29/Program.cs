using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Я удвоил свой доход минимум в два раза";
            string[] splitedString = s.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int c = 0;
            for (int i = 0; i<splitedString.Length; i++)
            {
                string word = splitedString[i];
                char[] sReverse = word.ToCharArray();
                Array.Reverse(sReverse);
                string reversedWord = new string(sReverse); 

                if (word == reversedWord)
                {
                    c++;
                }
                
            }

            Console.WriteLine("Count of polidroms is: " + c);

            Console.ReadKey();
        }
    }
}
