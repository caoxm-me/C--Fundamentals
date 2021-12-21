using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ReadFile
{
    class Program
    {
        static void TestFile()
        {
            string fileName = ".\\data";
            FileInfo fileInfo = new FileInfo(fileName);
            FileStream file = fileInfo.OpenRead();

            long length = fileInfo.Length;
            byte[] buffer = new byte[length];

            int n = file.Read(buffer, 0, buffer.Length);
            Console.WriteLine("Bytes read: " + n);

            file.Close();
        }
        static void Main(string[] args)
        {
            TestFile();
        }
    }
}
