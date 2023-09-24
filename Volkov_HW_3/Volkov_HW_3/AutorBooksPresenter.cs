using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_3
{
    internal class AutorBooksPresenter
    {
        private readonly IAutorBooksView view;
        private LibraryModel model;

        public AutorBooksPresenter(IAutorBooksView view)
        {
            this.view = view;
            model = new LibraryModel();
            view.AddAuthor += AddAutor;
            view.AddBook += AddBook;
            view.Filter += FilterBook;
            view.DeleteAuthor += DeleteAuthor;
            view.EditAuthor += EditAuthor;
            view.EditBook += EditBook;
            view.DeleteBook += DeleteBook;
            view.SaveXML += new EventHandler<EventArgs>(SaveXml);
            view.LoadXML += new EventHandler<EventArgs>(LoadXml);
        }

        private void SaveXml(object sender, EventArgs e) // сохранение в хмл
        {
            model.SaveXml();
        }

        private void LoadXml(object sender, EventArgs e) // загрузка хмл
        {
            model.LoadXml();
            Update();
        }

        private void FilterBook(string authorname)
        {
            if (authorname != null) // если не возвращает null то фильтрация продолжается
            {
                var filteredBooks = model.books.Where(b => b.AuthorBook.NameAutor == authorname).ToList();
                view.DisplayFilteredBooks(filteredBooks);
            }
            else
            {
                Update();
            }
        }

        private void Update() // обновляет весь список
        {
            view.DisplayAuthors(model.authors);
            view.DisplayBooks(model.books);
        }

        private void AddAutor(string nameauthor) // добавление автора
        {
            if (model.authors.Find(i => i.NameAutor == nameauthor) != null) // если такого автора находит с таким же именем выводится ошибка
            {
                view.DisplayError("Такой автор существует!");
            }
            else // если нет то добавляется
            {
                Author authortemp = new Author();
                authortemp.NameAutor = nameauthor;
                model.authors.Add(authortemp);
                Update();
            }
        }

        private void AddBook(string authorname,string namebook) // добавление книги
        {
            Author author1 = model.authors.FirstOrDefault(i => i.NameAutor == authorname);
            if(author1 != null)
            {
                Books bookstemp = new Books { NameBook = namebook, AuthorBook = author1 };
                model.books.Add(bookstemp);
            }
            else // если пользователь ввел автора которого нету то будет ошибка
            {
                view.DisplayError("Такого автора не существует!");
            }
            Update();
        }

       private void EditAuthor(string oldname, string newname) // редактирование
        {
            Author authortemp = model.authors.FirstOrDefault(i => i.NameAutor == oldname);
            if(authortemp != null)
            {
                authortemp.NameAutor = newname;
                foreach(Books i in model.books.Where(i => i.AuthorBook.NameAutor == oldname))
                {
                    i.AuthorBook.NameAutor = newname;
                }
            }
            else // если пользователь ввел автора которой не существует вывод ошибки
            {
                view.DisplayError("Такого автора не существует!");
            }
            Update();
        }

       private void DeleteAuthor(string authorname) // удаление автора
        {
            Author authortemp = model.authors.FirstOrDefault(i => i.NameAutor == authorname);
            if(authortemp != null)
            {
                model.authors.Remove(authortemp);
                model.books.RemoveAll(i => i.AuthorBook.NameAutor == authorname);

            }
            Update();
        }

        private void EditBook(string oldname, string newname) // редактирование книги
        {
            Books booktemp = model.books.FirstOrDefault(i => i.NameBook == oldname);
            if (booktemp != null)
            {
                booktemp.NameBook = newname;
            }
            else // если такой книги не существует ошибка
            {
                view.DisplayError("Такой книги не существует!");
            }
            Update();
        }

        private void DeleteBook(string name) // удаление книги
        {
            Books booktemp = model.books.FirstOrDefault(i => i.NameBook == name);
            if(booktemp != null)
            {
                model.books.Remove(booktemp);
                
            }
            Update();
        }
    }
}
