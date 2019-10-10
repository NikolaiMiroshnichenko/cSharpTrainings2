using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Asffa qwe sdf asdad dfdfs ASdds dffd Ahfo asdas";
            string [] splitedString  = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = splitedString.Count(i => i.StartsWith("A"));
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
