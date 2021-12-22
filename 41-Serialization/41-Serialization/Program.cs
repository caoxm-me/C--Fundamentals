using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _41_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Name = "cmiao";
            stu.Sex = true;
            stu.Id = 1120114;
            stu.Phone = "18444141578";
            stu.SetAddress("cc");
            string jsonStr = JsonConvert.SerializeObject(stu);
            Console.WriteLine(jsonStr);
            Student stu_copy = JsonConvert.DeserializeObject<Student>(jsonStr);
            Console.WriteLine(stu.Equals(stu_copy));

            JObject j = JObject.FromObject(stu);
            stu_copy = j.ToObject<Student>();
            Console.WriteLine("QUIT");
        }
    }
}
