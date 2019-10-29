using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Tasl37
{
    public class Word
    {
      public string Value { get; set; }
      public  int RepeatCount { get; set; }
        public Word (string Value, int RepeatCount)
        {
            this.Value = Value;
            this.RepeatCount = RepeatCount;
        }
        public string ToString()
        {
            string s = $"Word's properties is: {Value} - {RepeatCount}";
            return s;
        }
    }

   
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

            var words = new List<Word>();
            
            foreach (var keyValue in dictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            foreach (var KeyValue in dictionary)
            {
                Word word = new Word(KeyValue.Key, KeyValue.Value);
                words.Add(word);
            }

            for (int i = 0; i < words.Count; i++)
                {
                Console.WriteLine(words[i].ToString());
                }
             
            Console.ReadKey();
        }
    }
}
