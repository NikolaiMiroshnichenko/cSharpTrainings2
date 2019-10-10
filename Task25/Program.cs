using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            HashSet<string> someSet = new HashSet<string>();
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                someSet.Add(words[i]);
            }
            foreach (string v in someSet)
            {
                Console.WriteLine(v + " ");
            }
            Console.ReadKey();
        }
    }
}
