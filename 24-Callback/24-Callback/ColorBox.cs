using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Callback
{
    class ColorBox
    {
        private string[] color = { "white", "black", "red", "green", "blue"};

        // 定义委托类型
        public delegate void ChangeColor(string color);
        
        // 委托类型对象，事件处理器列表
        public List<ChangeColor> handlerList;
        
        // 模拟用户事件
        public void UserSelect(int colorNum)
        {
            // 调用事件处理器列表里面的每个事件处理器
            foreach(ChangeColor handler in handlerList)
            {
                handler.Invoke(color[colorNum]);
            }
            
        }

    }
}
