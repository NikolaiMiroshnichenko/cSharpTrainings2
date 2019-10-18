using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    public interface IFileSystem
    {
        string GetFileContent(String filename);
    }

    class FileSystem : IFileSystem
    {
        public string GetFileContent(String filename)
        {
            FileStream file = File.OpenRead(filename);
            byte[] array = new byte[file.Length];
            file.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            return textFromFile;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFileSystem fileSystem = new FileSystem();

            string s = Console.ReadLine();

            Console.WriteLine(fileSystem.GetFileContent(s));

            Console.ReadKey();
        }
    }
}
