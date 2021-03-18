using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InheritAndOverride
{
    class MyExample : Example
    {
        public override void Translate()
        {
            Console.WriteLine("号码：{0}", this.number);
        }
    }
}
