using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InheritAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Example e1 = new Example();
            e1.number = 111;
            e1.Translate();

            MyExample e2 = new MyExample();
            e2.number = 222;
            e2.Translate();
        }
    }
}
