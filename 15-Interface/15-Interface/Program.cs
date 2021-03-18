using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAudioPlayer player = new XiaoMiPlayer();
            int[] data = { 0x12, 0x2c};
            player.play(data);
        }
    }
}
