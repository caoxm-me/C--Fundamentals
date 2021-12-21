using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _37_XmlCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Xml document
            XmlDocument doc = new XmlDocument();
            // document head
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

            XmlElement student = doc.CreateElement("student");
            student.SetAttribute("id", "2020211111");
            root.AppendChild(student);

            XmlElement sex = doc.CreateElement("sex");
            student.AppendChild(sex);
            XmlElement name = doc.CreateElement("name");
            student.AppendChild(name);
            XmlElement phone = doc.CreateElement("phone");
            student.AppendChild(phone);

            sex.InnerText = "1";
            name.InnerText = "miao";
            phone.InnerText = "11011101110";

            // 输出到文件
            doc.Save("student.xml");
            // 输出到字符串
            string xmlStr = doc.InnerXml;
            Console.WriteLine("Xml content: " + xmlStr);
        }
    }
}
