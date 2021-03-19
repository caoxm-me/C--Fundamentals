using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Delegate2
{
    class Example
    {
        public delegate void SayFunction(string name);
        public static void SayBye(string name)
        {
            Console.WriteLine("bye, {0}", name);
        }
        public void SayHello(string name)
        {
            Console.WriteLine("hello, {0}", name);
        }
    }
}
