using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Constructor
{
    class Student
    {
        public int age;
        public string name;

        public Student()
        {

        }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
