using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;




namespace bonusTask_bailamthem
{
    class createXmlFile
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("thuvien");
            doc.AppendChild(root);

            Sach s1 = new Sach("nxb Giaoduc", "b01", "Lap trinh C#", "200");
            themSach(doc, root, s1);
        }
        class Sach
        {
            public String nxb;
            public String masach;
            public String tensach;
            public String giatien;
            public Sach(String nxb, String masach, String tensach, String giatien)
            {
                this.nxb = nxb;
                this.masach = masach;
                this.tensach = tensach;
                this.giatien = giatien;
            }
        }
        static void themSach(XmlDocument doc, XmlElement root, Sach s)
        {
            XmlElement sach = doc.CreateElement("cuonsach");
            root.AppendChild(sach);
            sach.SetAttribute("nxb", s.nxb);

            XmlElement masach = doc.CreateElement("masach");
            masach.InnerText = s.masach;
            sach.AppendChild(masach);

            XmlElement tensach = doc.CreateElement("tensach");
            tensach.InnerText = s.tensach;
            sach.AppendChild(tensach);

            XmlElement giatien = doc.CreateElement("giatien");
            giatien.InnerText = s.giatien;
            sach.AppendChild(giatien);

            doc.Save(Console.Out);
            doc.Save("thuvien.xml");
        }
    }
}
