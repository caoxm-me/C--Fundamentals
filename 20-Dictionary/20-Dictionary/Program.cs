using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            // 如果存在就抛出异常
            dic.Add("txt", "sublime-text.exe");
            dic.Add("bmp", "paint.exe");
            dic.Add("dib", "paint.exe");
            dic.Add("rtf", "word.exe");

            // 如果存在就覆盖
            dic["txt"]= "notepad.exe";

            if(dic.ContainsKey("xml"))
            {
                // 不存在则抛出异常
                string exe = dic["xml"];
            }

            dic.TryGetValue("txt", out string pngValue);

            Console.WriteLine(pngValue);

            // 不存在则取得默认值
            dic.TryGetValue("xml", out string xmlValue);
            Console.WriteLine(xmlValue);


        }
    }
}
