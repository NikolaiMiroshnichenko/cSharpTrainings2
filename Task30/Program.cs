using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task30
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "А роза упала на лапу Азора";
            s = s.Replace(" ", "").ToLower();
            char[] sArray = s.ToCharArray();
            Array.Reverse(sArray);
            string reversedS = new string(sArray);
            Boolean b = false;
            if (s == reversedS)
            {
                b = true;
            }

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
