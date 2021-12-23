using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _44_ThreadHandler
{
    class MyThread
    {
        public void Run()
        {
            for (int i = 3; i > 0; --i)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
    }
}
