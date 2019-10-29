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

        static Dictionary<string, int> GetUniqueWordsOccurance(string[] array)
        {
            var result = new Dictionary<string, int>();
            var uniqueWords = new List<string>(array.Distinct());
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                var count = array.Count(x => x.Equals(uniqueWords[i]));
                result.Add(uniqueWords[i], count);
            }
            return result;
        }

        static void Main(string[] args)
        {
            FileStream file = File.OpenRead(@"C:\13.txt");
            byte[] array = new byte[file.Length];
            file.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            string[] splitedString = textFromFile.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = GetUniqueWordsOccurance(splitedString);

           /* for (int i = 0; i < splitedString.Length; i++)
            {
                dictionary.Add(splitedString[i], i);
            }*/

            foreach (var keyValue in dictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.ReadKey();

        }
    }
}
