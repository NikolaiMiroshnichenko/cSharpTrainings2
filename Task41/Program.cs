using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    class Program
    {
        static void Main(string[] args)
        {

            /*String directoryName = "C:\\Consolidated";
            DirectoryInfo dirInfo = new DirectoryInfo(directoryName);
            if (dirInfo.Exists == false)
                Directory.CreateDirectory(directoryName);

            List<String> MyMusicFiles = Directory.GetFiles("C:\\Music", "*.*", SearchOption.AllDirectories).ToList();

            foreach (string file in MyMusicFiles)
            {
                FileInfo mFile = new FileInfo(file);
                // to remove name collisions
                if (new FileInfo(dirInfo + "\\" + mFile.Name).Exists == false)
                {
                    mFile.MoveTo(dirInfo + "\\" + mFile.Name);
                }*/

            DirectoryInfo dirInf = new DirectoryInfo("C:\\LearningFiles");
            List<String> someFileNames = Directory.GetDirectories("C:\\SomeFolder", "*.*", SearchOption.AllDirectories).ToList();
            foreach (string fileName in someFileNames)
            {
                FileInfo fileinfo = new FileInfo(fileName);
                fileinfo.MoveTo(dirInf + "\\" + fileinfo.Name);
            }

        }

    }
}

