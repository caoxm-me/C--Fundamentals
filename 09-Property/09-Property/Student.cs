using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Property
{
    class Student
    {

        private string name;

        // property 本质还是 getter 和 setter
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
