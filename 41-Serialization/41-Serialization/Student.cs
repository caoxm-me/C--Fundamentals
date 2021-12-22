using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Serialization
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }

        public string Phone { get; set; }

        public string address;

        public void SetAddress(string addr)
        {
            address = addr;
        }

        public string GetAddress()
        {
            return address;
        }
    }
}
