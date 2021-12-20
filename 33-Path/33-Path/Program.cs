using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(".\\test");

            string dirPath = ".\\test\\x";
            DirectoryInfo info = new DirectoryInfo(dirPath);
            info.Create();
            string dirPath2 = ".\\test\\y";
            DirectoryInfo info2 = new DirectoryInfo(dirPath2);
            info2.Create();
            info2.Delete();

            File.Create(".\\test\\x\\abcd.txt");

            FileInfo fileInfo = new FileInfo(".\\test\\x\\abc.txt");
            long size = fileInfo.Length;
            fileInfo.MoveTo(".\\test\\x\\123.txt");
        }
    }
}
