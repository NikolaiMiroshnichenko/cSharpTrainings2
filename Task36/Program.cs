using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = File.OpenRead(@"C:\13.txt");
            byte[] array = new byte[file.Length];
            file.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            string[] splitedString = textFromFile.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            for (int i = 0; i < splitedString.Length; i++)
            {
                dictionary.Add(i, splitedString[i]);
            }
            foreach (KeyValuePair<int, string> keyValue in dictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }


            int count(string key)
            {
                return dictionary.Where(x => x.Value == key).ToList().Count; ;
            }

            foreach (string word in dictionary.Values)
            {
                count(word);
                int z = count(word);
                Console.WriteLine("Repeats of " + word + " is " + z);
            }

            Console.ReadKey();

        }
    }
}
