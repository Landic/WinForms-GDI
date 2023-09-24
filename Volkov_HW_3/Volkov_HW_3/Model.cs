using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace Volkov_HW_3
{
    public class Author : IAuthor
    {
        public string NameAutor { get; set; }

        public Author() 
        { 
            NameAutor = string.Empty;
        }
    }

    public class Books : IBook
    {
        public string NameBook { get; set; }
        public Author AuthorBook { get; set; }

        public Books()
        {
            NameBook = string.Empty;
            AuthorBook = new Author();
        }
    }

    internal class LibraryModel : ILibraryModel
    {
        public List<Books> books { get; set; }
        public List<Author> authors { get; set; }

        public LibraryModel()
        {
            books = new List<Books>();
            authors = new List<Author>();
        }

        public void SaveXml() // сериализация в XML
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Library.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LibraryData));
                    LibraryData data = new LibraryData { Authors = authors, Books = books };
                    serializer.Serialize(writer, data);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void LoadXml() // Десереализация XML
        {
            try
            {
                if (File.Exists("Library.xml"))
                {
                    using (StreamReader reader = new StreamReader("Library.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(LibraryData));
                        LibraryData data = (LibraryData)serializer.Deserialize(reader);
                        authors = data.Authors;
                        books = data.Books;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }

    [Serializable]
    public class LibraryData //этот класс нужен для сохранения и загрузки данных
    {
        public List<Author> Authors { get; set; }
        public List<Books> Books { get; set; }
    }
}
