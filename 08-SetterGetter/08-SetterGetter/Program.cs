using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SetterGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("cmiao");
            Console.WriteLine(stu.GetName());
            stu.SetName("amiao");
            Console.WriteLine(stu.GetName());

        }
    }
}
