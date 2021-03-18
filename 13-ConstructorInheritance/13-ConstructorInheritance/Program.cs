using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ConstructorInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D pt = new Point3D(1, -1, 3);
            // 打印对象的时候会自动调用对象的ToString方法
            Console.WriteLine(pt);
        }
    }
}
