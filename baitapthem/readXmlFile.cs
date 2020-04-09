using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace bonusTask_bailamthem
{
    class readXmlFile
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("thuvien.xml");
            XmlElement root = doc.DocumentElement;
            printLib(root);
        }
        static void printLib(XmlNode node)
        {
            Console.WriteLine("\nNode name: " + node.Name);
            Console.WriteLine("Node type: " + node.NodeType);
            Console.WriteLine("Node value: " + node.Value);
            XmlNodeList children = node.ChildNodes;
            if(children.Count > 0)
            {
                
                for (int i = 0; i < children.Count; i++ )
                {
                    printLib(children.Item(i));
                }
                Console.WriteLine("\n-----KET THUC NODE " + node.Name + "-----------");
            }
        }
    }
}
