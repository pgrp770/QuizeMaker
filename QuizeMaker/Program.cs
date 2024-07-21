using System.Xml;

namespace QuizeMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Path = "C:\\Users\\pgrp7\\OneDrive\\Desktop\\programming\\week4\\QuizeMaker\\QuizeMaker\\try.xml";
            XmlTextWriter xmlTextWriter = new XmlTextWriter(Path, System.Text.Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("Pini");
            xmlTextWriter.WriteStartElement("Tzvi");
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
            
        }
    }
}
