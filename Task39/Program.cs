using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task39
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\LearningFiles");
            FileInfo file13 = new FileInfo(@"C:\13.txt");
            FileInfo file2 = new FileInfo(@"C:\2.txt");
            FileInfo file3 = new FileInfo(@"C:\3.txt");

            if (file13.Exists)
            {
                File.Move(@"C:\13.txt",@"C:\LearningFiles\13.txt");
            }

            if (file2.Exists)
            {
                File.Move(@"C:\2.txt", @"C:\LearningFiles\2.txt");
            }

            if (file3.Exists)
            {
                File.Move(@"C:\3.txt", @"C:\LearningFiles\1.txt");
            }

        }
    }
}
