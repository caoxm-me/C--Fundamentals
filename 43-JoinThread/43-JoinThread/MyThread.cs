using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _43_JoinThread
{
    class MyThread
    {
        public void Run()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine("当前线程id: " + t.ManagedThreadId);

            for (int i = 100; i > 0; --i)
            {
                Console.WriteLine("倒计时线程：" + i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("倒计时线程结束");
        }
        
    }
}
