using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "Hello";
            Console.WriteLine("End with o: " + str1.EndsWith("o"));
            Console.WriteLine("Start with H: " + str2.StartsWith("H"));
            Console.WriteLine(String.Format("Is equal: {0}", str1.Equals(str2)));
            string str3 = "a,b,c";
            string[] strArray = str3.Split(',');
            string str4 = "     Hello      ";
            Console.WriteLine("Trim: " + str4.Trim());
            Console.WriteLine(str1.Replace("llo", "at"));
            Console.WriteLine(str1.Insert(1, "zzz"));
            Console.WriteLine(str2.IndexOf('l'));
            Console.WriteLine(str2.LastIndexOf('l'));
        }
    }
}
