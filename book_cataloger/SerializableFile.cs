using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace book_cataloger
{
    [Serializable]
    public class SerializableFile
    {
        public static List<Book> ReadFile(string path)
        {
            var books = new List<Book>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                books = (List<Book>)formatter.Deserialize(fs);
            }
            return books;
        }
        public static void WriteFile(List<Book> books,string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            using (FileStream fs = new FileStream(path, FileMode.Truncate))
            {
                formatter.Serialize(fs, books);
            }
        }
    }
}

