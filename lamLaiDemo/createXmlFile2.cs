using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RedoDemo
{
    class createXmlFile2
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("lophoc");
            doc.AppendChild(root);

            SinhVien s1 = new SinhVien("sv01", "Johnhy Dang", "20", "Alaska");
            SinhVien s2 = new SinhVien("sv02", "Da Baby", "30", "Indiana");
            SinhVien s3 = new SinhVien("sv03", "Laura", "19", "California");

            themSinhVien(doc, root, s1);
            themSinhVien(doc, root, s2);
            themSinhVien(doc, root, s3);

        }
        class SinhVien
        {
            public String masv;
            public String hoten;
            public String tuoi;
            public String diachi;
            public SinhVien(String masv, String hoten, String tuoi, String diachi)
            {
                this.masv = masv;
                this.hoten = hoten;
                this.tuoi = tuoi;
                this.diachi = diachi;
            }
        }
        static void themSinhVien(XmlDocument doc, XmlElement root, SinhVien s)
        {
            XmlElement sv = doc.CreateElement("sinhvien");
            root.AppendChild(sv);
            sv.SetAttribute("masv", s.masv);
            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = s.hoten;
            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = s.tuoi;
            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = s.diachi;

            sv.AppendChild(hoten);
            sv.AppendChild(tuoi);
            sv.AppendChild(diachi);
            doc.Save(Console.Out);
            doc.Save("lophoc2.xml");

        }
    }
}
