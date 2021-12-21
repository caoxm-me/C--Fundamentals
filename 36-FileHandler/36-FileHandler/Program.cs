using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_FileHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = ".\\test\\data";
            FileInfo fileInfo = new FileInfo(fileName);
            // 创建文件目录
            fileInfo.Directory.Create();
            FileStream fileWriter = fileInfo.OpenWrite();

            try
            {
                byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04 };
                fileWriter.Write(data, 0, data.Length);
            }
            finally
            {
                fileWriter.Close();
            }

            byte[] buffer = new byte[fileInfo.Length];
            using (FileStream fileReader = fileInfo.OpenRead())
            {
                fileReader.Read(buffer, 0, buffer.Length);
            }
            
            foreach(byte b in buffer)
            {
                Console.WriteLine(b);
            }

        }
    }
}
