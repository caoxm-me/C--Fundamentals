using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "integer: " + 30;
            Console.WriteLine(str1);

            string str2 = string.Format("Age:{0}", 16);
            Console.WriteLine(str2);

        }
    }
}
