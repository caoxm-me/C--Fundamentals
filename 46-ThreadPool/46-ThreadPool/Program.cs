using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _46_ThreadPool
{
   

    class Program
    {
        static void SimpleTask(object o)
        {
            for(int i = 3; i > 0; --i)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            // 线程池中的线程均是后台线程，进程不会等待其结束
            ThreadPool.QueueUserWorkItem(new WaitCallback(SimpleTask));
            // 卡住主线程，让进程不结束
            Console.ReadLine();
            Console.WriteLine("Quit");
        }
    }
}
