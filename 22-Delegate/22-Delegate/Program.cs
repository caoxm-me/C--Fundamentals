using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Delegate
{
    // 委托用来描述方法，相当于函数指针
    // 在函数声明中使用delegate，则原函数名变成描述该类函数的委托类型
    public delegate void TestFunction(int i, int j);
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            // 实例化Example类
            Example e = new Example();
            // 创建应用到Function1的委托实例
            TestFunction pf = new TestFunction(e.Function1);
            pf(a, b);

            pf = new TestFunction(e.Function2);
            pf(a, b);
            
        }

        
    }
}
