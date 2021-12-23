using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _45_ThreadLock
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFactory fac = new MyFactory();
            Thread threadProduce = new Thread(fac.Produce);
            Thread threadConsume = new Thread(fac.Consume);
            threadProduce.Start();
            threadConsume.Start();
        }
    }
}
