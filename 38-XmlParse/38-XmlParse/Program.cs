using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _38_XmlParse
{
    class Program
    {
        static void ParseXml()
        {
            string fileName = ".\\student.xml";
            FileInfo fileInfo = new FileInfo(fileName);
            FileStream file = fileInfo.OpenRead();

            XmlDocument xml = new XmlDocument();
            xml.Load(file);
            // 提取根元素
            XmlElement root = xml.DocumentElement;
            // 提取根元素的全部student子元素
            XmlNodeList students = root.SelectNodes("student");
            // 选中第一个student子元素的name子元素
            string name = students[0]["name"].InnerText;
            Console.WriteLine("Student name: " + name);
            // 遍历第二个student的全部子元素
            foreach(XmlNode node in students[1].ChildNodes)
            {
                Console.WriteLine(node.InnerText);
            }

            XmlElement a = (XmlElement)xml.SelectSingleNode("root/student");
            Console.WriteLine(a.InnerText);
            XmlElement b = (XmlElement)root.SelectSingleNode("student");
            Console.WriteLine(b.InnerText);


        }

        static void Main(string[] args)
        {
            ParseXml();
        }
    }
}
