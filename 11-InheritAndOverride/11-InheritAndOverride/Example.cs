using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InheritAndOverride
{
    class Example
    {
        public int number;

        public void Output()
        {
            Console.WriteLine(number);
        }

        public virtual void Translate()
        {
            Console.WriteLine("numbers: {0}", this.number);
        }
    }
}
