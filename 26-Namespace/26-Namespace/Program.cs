using ss = _26_Namespace.School.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _26_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ss stu1 = new ss();
            stu1.name = "miao";
            stu1.age = 17;

            School.Student stu2= new School.Student();
            stu2.name = "miao";
            stu2.age = 20;
        }
    }
}
