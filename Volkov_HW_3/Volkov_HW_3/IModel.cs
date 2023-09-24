using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_3
{
    internal interface IAuthor
    {
        string NameAutor { get; set; }
    }

    internal interface IBook
    {
        string NameBook { get; set; }
        Author AuthorBook { get; set; }
    }

    internal interface ILibraryModel 
    {
        List<Books> books { get; set; }
        List<Author> authors { get; set; }

        void SaveXml();
        void LoadXml();
    }
}
