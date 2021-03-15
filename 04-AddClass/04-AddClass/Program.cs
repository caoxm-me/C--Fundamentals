using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AddClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.id = 20200001;
            stu.name = "cmiao";
            stu.gender = true;
            stu.phone = "1111111111";

            Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", stu.id, stu.name, stu.gender ? "male" : "female", stu.phone));
        }
    }

    class Example
    {
        // Default class modifier: public
        // Internal types or members are accessible only within files in the same assembly 
        // Multiple classes can be defined in one source file though not recommended
    }
}
