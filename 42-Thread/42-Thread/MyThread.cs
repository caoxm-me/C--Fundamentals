using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _42_Thread
{
    class MyThread
    {
        public bool stopFlag = false;
        public void StopNow()
        {
            stopFlag = true;
        }

        public void Run()
        {
            for(int i = 1000; i>0; --i)
            {
                if(stopFlag)
                {
                    break;
                }
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
