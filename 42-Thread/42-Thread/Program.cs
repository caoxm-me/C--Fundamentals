using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _42_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t = new MyThread();
            Thread thread = new Thread(t.Run);
            thread.Start();

            for(int i=10; i>0; --i)
            {
                Console.WriteLine("Main thread: " + i);
                Thread.Sleep(1000);
            }

            t.StopNow();
        }
    }
}
