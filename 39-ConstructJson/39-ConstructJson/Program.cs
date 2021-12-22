using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ConstructJson
{
    class Program
    {
        static void Main(string[] args)
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

            j.Add("coloars", colors);
            string jsonStr = j.ToString();
            Console.WriteLine(jsonStr);
        }
    }
}
