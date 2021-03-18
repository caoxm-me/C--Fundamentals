using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SetterGetter
{
    class Student
    {
        private string name;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public Student(string name)
        {
            this.name = name;
        }
    }
}
