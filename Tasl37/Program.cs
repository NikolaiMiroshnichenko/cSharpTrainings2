using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Tasl37
{
    class Word
    {
        string value;
        int repeatCount;
    }
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
            List<Word> words = new List<Word>();
            foreach (KeyValuePair<int, string> keyValue in dictionary)
            {
                words.Add(Word word("2",12));
            }
        }
    }
}
