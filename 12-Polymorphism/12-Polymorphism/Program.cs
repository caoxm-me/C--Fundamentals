using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Say();

            // polymorphism, parent class refer to a child object
            p = new Student();
            p.Say();
        }
    }
}
