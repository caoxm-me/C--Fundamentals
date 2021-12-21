using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_WriteFile
{
    class Program
    {
        static void TestFile()
        {
            string fileName = ".\\test\\data"; 
            FileInfo fileInfo = new FileInfo(fileName);
            fileInfo.Directory.Create();

            FileStream file = fileInfo.OpenWrite();
            byte[] data = new byte[] {0, 1, 2, 3, 0x0a, 0x0b, 0x0c, 0x0d};
            file.Write(data, 0, 8);
            file.Close();
        }
        static void Main(string[] args)
        {
            TestFile();
        }
    }
}
