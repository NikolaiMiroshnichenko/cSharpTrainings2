using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = "asd dfg asd qwer asd dfggfd qwer asd As As dfgh As As ef";

            string[] splitedString = s.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
