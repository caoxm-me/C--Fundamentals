using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Traverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(0);
            list.Add(1);
            list.Add(2);

            // 迭代
            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }


            // 枚举器
            List<int>.Enumerator en = list.GetEnumerator();

            while(en.MoveNext())
            {
                int item = en.Current;
                Console.WriteLine(item + " ");
            }
            
        }
    }
}
