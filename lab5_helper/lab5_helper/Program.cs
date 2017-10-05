using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace lab5_helper
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string filepath = "university.xml";
			if (!File.Exists(filepath))
				CreateXMLDocument(filepath);
		}

		private static void CreateXMLDocument(string filepath)
		{
			XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF8);
			xtw.WriteStartDocument();
			xtw.WriteStartElement("university");

			xtw.WriteStartElement("faculties");
			xtw.WriteEndElement();

			xtw.WriteStartElement("disciplines");
			xtw.WriteEndElement();

			xtw.WriteStartElement("students");
			xtw.WriteEndElement();

			xtw.WriteEndElement();
			xtw.WriteEndDocument();
			xtw.Close();
		}
	}
}