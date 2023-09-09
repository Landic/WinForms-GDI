using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Log
{
    public interface ILog
    {
        void Print(string s);
    }

    public class ConsoleLog : ILog
    {
        public void Print(string s)
        {
            Console.WriteLine(s); // вывод действия в консоль
        }
    }

    public class XMLLog : ILog
    {
        public void Print(string s)
        {
            using (XmlTextWriter writer = new XmlTextWriter("Logs.xml", null))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Logs");
                writer.WriteString(DateTime.Now.ToString()); // записывает дату и время когда произошло действие
                writer.WriteString($"\t{s}"); // само действие
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }

    public class FileLog : ILog
    {
        public void Print(string s)
        {
            using (StreamWriter writer = new StreamWriter("Logs.txt", true))
            {
                writer.Write(DateTime.Now.ToString()); // записывает дату и время когда произошло действие
                writer.Write($"\t{s}\n"); // само действие
            }
        }
    }
}
