using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Event
{
    class Program
    {
        static void ChangeColor(string color)
        {
            Console.WriteLine("User select color: " + color);
        }


        static void Main(string[] args)
        {
            ColorBox box = new ColorBox();
            // 注册回调函数
            box.Handler += ChangeColor;           
            box.UserSelect(1);

            // 注册另一个回调函数
            box.Handler += ChangeColor;
            box.UserSelect(0);
        }
    }
}
