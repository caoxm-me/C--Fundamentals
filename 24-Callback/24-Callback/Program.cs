using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Callback
{
    class Program
    {
        static void OnColorChanged1(string color)
        {
            Console.WriteLine("User select color: " + color);
        }

        static void OnColorChanged2(string color)
        {
            Console.WriteLine("User select color: " + color);
        }

        static void Main(string[] args)
        {
            ColorBox box = new ColorBox();
            // 向对象注册事件处理器（回调函数）
            box.handlerList = new List<ColorBox.ChangeColor> { };
            box.handlerList.Add(new ColorBox.ChangeColor(Program.OnColorChanged1));
            box.handlerList.Add(new ColorBox.ChangeColor(Program.OnColorChanged2));
            box.UserSelect(2);
        }
    }
}
