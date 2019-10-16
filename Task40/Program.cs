using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo info13 = new FileInfo(@"C:\LearningFiles\13.txt");
            FileInfo info2 = new FileInfo(@"C:\LearningFiles\2.txt");
            FileInfo info3 = new FileInfo(@"C:\LearningFiles\1.txt");

            string s13 = "";
            if (info13.Exists)
            {
                s13 = info13.FullName;
            }

            string s2 = "";
            if (info2.Exists)
            {
                s2 = info2.FullName;
            }

            string s3 = "";
            if (info3.Exists)
            {
                s3 = info3.FullName;
            }

            Console.WriteLine(s13);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.ReadKey();
        }
    }
}
