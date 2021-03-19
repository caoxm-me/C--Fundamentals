using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OverrideOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFraction a = new MyFraction(1, 2);
            MyFraction b = new MyFraction(3, 4);
            MyFraction c = a * b;
            c.Print();
        }
    }
}
