using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RedoDemo
{
    class createXmlFile1
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("lophoc");
            doc.AppendChild(root);
            XmlElement sinhvien = doc.CreateElement("sinhvien");
            XmlElement hoten = doc.CreateElement("hoten");
            XmlElement tuoi = doc.CreateElement("tuoi");
            XmlElement diachi = doc.CreateElement("diachi");
            root.AppendChild(sinhvien);
            sinhvien.SetAttribute("masv", "sv01");
            sinhvien.AppendChild(hoten);
            hoten.InnerText = "Johnny Dang";
            sinhvien.AppendChild(tuoi);
            tuoi.InnerText = "20";
            sinhvien.AppendChild(diachi);
            diachi.InnerText = "Indiana";
            doc.Save(Console.Out);
            doc.Save("lophoc1.xml");
            Console.WriteLine("\nDone");
        }
    }
}
