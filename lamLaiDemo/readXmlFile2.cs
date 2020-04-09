using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace RedoDemo
{
    class readXmlFile2
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("lophoc2.xml");
            XmlElement root = doc.DocumentElement;
            printNode(root);
        }
        static void printNode(XmlNode node)
        {
            Console.WriteLine("\nNode Name: " + node.Name);
            Console.WriteLine("Node type: " + node.NodeType);
            Console.WriteLine("Node value: " + node.Value);
            XmlNodeList children = node.ChildNodes;
            if(children.Count > 0)
            {
                for(int i = 0; i < children.Count; i++ )
                {
                    printNode(children.Item(i));
                }
                Console.WriteLine("\nKet thuc node " + node.Name + "-------------------");
            }
        }
    }
}
