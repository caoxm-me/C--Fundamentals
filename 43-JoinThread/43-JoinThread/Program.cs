using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _43_JoinThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始");
            MyThread t = new MyThread();
            Thread thread = new Thread(t.Run);
            // 所有前台线程结束之后进程就结束了，不会等待后台线程执行完
            thread.IsBackground = true;
            thread.Start();

            for(int i = 5; i > 0; --i)
            {
                Console.WriteLine("主线程：" + i);
                Thread.Sleep(1000);
            }

            //thread.Join();
            Console.WriteLine("主线程结束");

        }
    }
}
