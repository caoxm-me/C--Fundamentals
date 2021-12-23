using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _44_ThreadHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t = new MyThread();
            for(int i = 1; i <= 1000; ++i)
            {
                Console.WriteLine(string.Format("创建第{0}个线程", i));
                Thread thread = new Thread(t.Run);
                thread.Start();
                thread.Join();
                // 调用GC，回收线程句柄
                //GC.Collect();
            }
        }
    }
}
