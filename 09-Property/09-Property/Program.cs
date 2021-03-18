using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Name = "cmiao";
            Console.WriteLine(stu.Name);
        }
    }
}
