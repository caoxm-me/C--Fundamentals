using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method
{
    class Student
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void Output()
        {
            Console.WriteLine(this.name);
        }
    }
}
