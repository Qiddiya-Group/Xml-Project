
using System;
<<<<<<< HEAD
using System.Threading;
using System.Xml;
=======
using System.Xml;

>>>>>>> 11788a0 (Read Xml file Function)

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


            XmlElement element5 = xmldoc.CreateElement("conclusion");
            XmlText Text5 = xmldoc.CreateTextNode("Best Regards,");
            element3.AppendChild(element5);
            element5.AppendChild(Text5);


<<<<<<< HEAD
            xmldoc.Save(@"C:\Users\moham\Desktop\XMLproject\project.xml");

=======
            xmldoc.Save(@"C:/Users/hiro1/Desktop/project.xml");
            Console.WriteLine(xmldoc.InnerXml);
>>>>>>> 11788a0 (Read Xml file Function)

        }
        static void ReadXmlFile() {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"C:/Users/hiro1/Desktop/project.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.WriteLine(element+":");
                string text = node.InnerText;
                Console.WriteLine(text);

            }
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD

            Thread writeThread = new Thread(WriteXMLFile);

            writeThread.Start();
            
=======
            WriteXMLFile();
            ReadXmlFile();


>>>>>>> 11788a0 (Read Xml file Function)
        }
    }
}

