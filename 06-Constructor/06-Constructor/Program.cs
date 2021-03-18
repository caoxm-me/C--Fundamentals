using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Student stu2 = new Student("cmiao");
            Student stu3 = new Student("cmiao", 19);
        }
    }
}
