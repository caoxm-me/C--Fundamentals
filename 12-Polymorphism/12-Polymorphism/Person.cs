using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism
{
    class Person
    {
        public virtual void Say()
        {
            Console.WriteLine("I am a person");
        }
    }
}
