using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Event
{
    class ColorBox
    {
        private string[] colors = { "green", "blue"};

        public delegate void ChangeColor(string color);

        // 定义事件，用于绑定回调函数
        public event ChangeColor Handler;

        public void UserSelect(int index)
        {
            string color = colors[index];
            Handler.Invoke(color);
        }
    }
}
