using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            // 定义在一个类中的委托也是一个内部类型，如果要在其他类中使用需要写出全名
            _23_Delegate2.Example.SayFunction pf = new _23_Delegate2.Example.SayFunction(e.SayHello);
            // 下面两种调用方式是等价的
            pf("cmiao");
            pf.Invoke("amiao");
            // 委托绑顶一个静态方法
            pf = new _23_Delegate2.Example.SayFunction(Example.SayBye);
            pf("bmiao");
        }
    }
}
