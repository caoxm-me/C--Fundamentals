using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    // 接口名字必须以大写字母I开头
    // 一个类只能有一个父类，但是可以实现多个接口，相当于多继承的功能
    public interface IAudioPlayer
    {
        void play(int[] data);
    }
}
