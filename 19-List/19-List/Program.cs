using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();

            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);

            foreach(int i in l)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            for(int i = 0; i < l.Count(); ++i)
            {
                Console.Write("{0} ", l[i]);
            }
        }
    }
}
