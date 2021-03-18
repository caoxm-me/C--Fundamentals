using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(4);
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            for(int i = 0; i < arr.Size(); ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
