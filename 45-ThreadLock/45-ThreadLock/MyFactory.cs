using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _45_ThreadLock
{
    class MyFactory
    {
        public object resourceLock = new object();
        List<int> repo = new List<int>();

        public void Produce()
        {
            Random rand = new Random();
            while(true)
            {
                lock(resourceLock)
                {
                    int item = rand.Next();
                    repo.Add(item);
                    Console.WriteLine(string.Format("生产商品: {0}", item));                    
                }
                Thread.Sleep(500);
            }
            
            
        }

        public void Consume()
        {    
            while(true)
            {
                lock(resourceLock)
                {

                    if (repo.Count > 0)
                    {
                        int item = repo[0];
                        repo.RemoveAt(0);
                        Console.WriteLine(string.Format("消费商品: {0}", item));
                    }                   
                }
                Thread.Sleep(1000);
            }
 
        }
    }
}
