using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _47_Timer
{
    class Program
    {
        static void SimpleTask(object o)
        {
            for(int i = 3; i > 0; --i)
            {
                Console.WriteLine(i);
                Thread.Sleep(150);
            }
        }
        static void Main(string[] args)
        {
            Timer timer = new Timer(new TimerCallback(SimpleTask), null, 1000, 1000);

            // 定时器也是后台线程，需要卡住主线程以让进程不退出
            Console.ReadLine();
            // 定时器包含非托管资源，需要调用Dispose方法
            timer.Dispose();
            Console.WriteLine("Quit");
        }
    }
}
