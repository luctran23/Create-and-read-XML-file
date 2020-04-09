using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RedoDemo
{
    class readXmlFile1
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("lophoc2.xml");

            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes =  root.SelectNodes("sinhvien");
            
            foreach(XmlNode node in nodes )
            {
                Console.WriteLine("------------------\nMa sinh vien: " + node.Attributes[0].InnerText);
                Console.WriteLine("Ho ten: " + node.SelectNodes("hoten")[0].InnerText);
                Console.WriteLine("Tuoi: " + node.SelectNodes("tuoi")[0].InnerText);
                Console.WriteLine("Dia chi: " + node.SelectNodes("diachi")[0].InnerText);
            }
        }
    }
}
