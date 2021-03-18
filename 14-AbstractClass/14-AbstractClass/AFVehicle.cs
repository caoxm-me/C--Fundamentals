using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_AbstractClass
{
    // 子类继承抽象类
    class AFVehicle : FutureVehicle
    {
        // 实例化抽象方法
        public override void fly()
        {
            Console.WriteLine("fly");
        }

        public override void run()
        {
            Console.WriteLine("run");
        }
    }
}
