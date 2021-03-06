
using System;
using System.Threading;
using System.Xml;

namespace Xml_Project
{
    class Program
    {
        static void WriteXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Project");
            xmldoc.AppendChild(root);

            XmlElement element1 = xmldoc.CreateElement("from");
            XmlText Text1 = xmldoc.CreateTextNode("Qiddiya Group");
            root.AppendChild(element1);
            element1.AppendChild(Text1);

            XmlElement element2 = xmldoc.CreateElement("to");
            XmlText Text2 = xmldoc.CreateTextNode("Tuwaiq Programming Bootcamp");
            root.AppendChild(element2);
            element2.AppendChild(Text2);

            XmlElement element3 = xmldoc.CreateElement("content");
            root.AppendChild(element3);

            XmlElement element4 = xmldoc.CreateElement("Message");
            XmlText Text4 = xmldoc.CreateTextNode("Here you can find our work of writing and reading XML file using threading and clean code.");
            element3.AppendChild(element4);
            element4.AppendChild(Text4);

            XmlElement element5 = xmldoc.CreateElement("Members");
            XmlText Text5 = xmldoc.CreateTextNode("\n Shahad Alshehri: Computer Science ,\n Albandry AlQaseemi: Computer Science ,\n Rahaf Alqhtani :Information System ,\n Mohammed Albalawi: Computer Science ,\n Saud Alshammari: Management Information System.\n ");
            element3.AppendChild(element5);
            element5.AppendChild(Text5);

            XmlElement element6 = xmldoc.CreateElement("conclusion");
            XmlText Text6 = xmldoc.CreateTextNode("Best Regards,");
            element3.AppendChild(element6);
            element6.AppendChild(Text6);


            xmldoc.Save(@"C:\program\project.xml");
            Console.WriteLine("Created Successfully!");

        }
        static void ReadXmlFile() {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"C:\program\project.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.Write(element+": ");
                string text = node.InnerText;
                Console.WriteLine(text);

            }
        }
        static void Main(string[] args)
        {

            Thread writeThread = new Thread(WriteXMLFile);
            writeThread.Start();
            writeThread.Join();
            
            Thread ReadThread = new Thread(ReadXmlFile);
            ReadThread.Start();

        }
    }
}

