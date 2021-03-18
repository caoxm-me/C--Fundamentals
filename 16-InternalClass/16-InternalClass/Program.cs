using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InternalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // 注意内部类型的全名是 命名空间.外部类.内部类
            _16_InternalClass.Example.Item item = new _16_InternalClass.Example.Item();
            item.id = 11;
            item.name = "hhh";
        }
    }
}
