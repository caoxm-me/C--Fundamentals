using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_ParseJson
{
    class Program
    {
        static string CreateJson()
        {
            JObject j = new JObject();
            j.Add("sex", true);
            j.Add("phone", 11111111111);
            j["name"] = "miao";
            j["id"] = 2020111111;

            JArray colors = new JArray();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");

            j.Add("colors", colors);
            return j.ToString();
        }

        static void Main(string[] args)
        {
            JObject j = JObject.Parse(CreateJson());
            int id = (int)j["id"];
            bool sex = (bool)j["sex"];
            string name = "";

            if (j.ContainsKey("name"))
            {
                name = (string)j.GetValue("name");
            }

            Console.WriteLine("sex: " + sex + "id: " + id + "name: " + name);

            JArray colors = (JArray)j["colors"];
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }
            
        }
    }
}
