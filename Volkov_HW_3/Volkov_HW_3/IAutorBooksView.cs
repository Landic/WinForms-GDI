﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_3
{
    internal interface IAutorBooksView
    {
        event Action<string> AddAuthor;
        event Action<string, string> AddBook;
        event Action<string> Filter;
        event Action<string> DeleteAuthor;
        event Action<string, string> EditAuthor;
        event Action<string, string> EditBook;
        event Action<string> DeleteBook;
        event EventHandler<EventArgs> SaveXML;
        event EventHandler<EventArgs> LoadXML;

        void DisplayAuthors(List<Author> authors);
        void DisplayBooks(List<Books> books);
        void DisplayFilteredBooks(List<Books> books);

        void DisplayError(string message);
    }
}
