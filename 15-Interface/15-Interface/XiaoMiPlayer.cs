using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    class XiaoMiPlayer : IAudioPlayer
    {
        public void play(int[] data)
        {
            Console.WriteLine("playing....");
        }
    }
}
