using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a * 5;
            Console.WriteLine(b);

            char[] data = {'7', '8', '9'};
            int number1 = Convert.ToInt32(string.Join("", data));
            int number2 = Convert.ToInt32(new string(data));
            int number3 = Convert.ToInt32(string.Concat<char>(data));

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

        }
    }
}
