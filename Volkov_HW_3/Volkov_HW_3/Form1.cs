using static System.Reflection.Metadata.BlobBuilder;

namespace Volkov_HW_3
{
    public partial class Form1 : Form, IAutorBooksView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Action<string> AddAuthor;
        public event Action<string, string> AddBook;
        public event Action<string> Filter;
        public event Action<string> DeleteAuthor;
        public event Action<string, string> EditAuthor;
        public event Action<string, string> EditBook;
        public event Action<string> DeleteBook;
        public event EventHandler<EventArgs> SaveXML;
        public event EventHandler<EventArgs> LoadXML;

        void IAutorBooksView.DisplayAuthors(List<Author> authors) // вывод всех авторов нужно для обновление информации
        {
            AuthotComboBox.Items.Clear();
            foreach (var i in authors)
            {
                AuthotComboBox.Items.Add(i.NameAutor);
            }
            if (AuthotComboBox.Items.Count > 0)
            {
                AuthotComboBox.SelectedIndex = 0;
            }
        }

        void IAutorBooksView.DisplayBooks(List<Books> books) // вывод всех книг нужно для обновление информации
        {
            BookList.Items.Clear();
            foreach (var i in books)
            {
                BookList.Items.Add(i.NameBook);
            }
        }

        void IAutorBooksView.DisplayFilteredBooks(List<Books> books) // фильтрация 
        {
            BookList.Items.Clear();

            foreach (Books i in books)
            {
                BookList.Items.Add($"{i.NameBook}");
            }
        }

        private void AddAuthorToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            using (var addAuthorForm = new AddAuthorForm())
            {
                if (addAuthorForm.ShowDialog() == DialogResult.OK)
                {
                    AddAuthor?.Invoke(addAuthorForm.AuthorNamestr);
                }
            }
        }

        private void AddBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var AddBooksForm = new AddBooksForm())
            {
                if (AddBooksForm.ShowDialog() == DialogResult.OK)
                {
                    AddBook?.Invoke(AddBooksForm.AuthorName, AddBooksForm.BooksName);
                }
            }
        }

        private void DeleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthotComboBox.SelectedItem != null)
            {
                string selectedAuthor = AuthotComboBox.SelectedItem.ToString();
                DeleteAuthor?.Invoke(selectedAuthor);
            }
        }

        private void EditAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var EditAuthorForm = new EditAuthorForm())
            {
                if (EditAuthorForm.ShowDialog() == DialogResult.OK)
                {
                    EditAuthor?.Invoke(EditAuthorForm.OldAuthor, EditAuthorForm.NewAuthor);
                }
            }
        }

        private void EditBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var EditBookForm = new EditBookForm())
            {
                if (EditBookForm.ShowDialog() == DialogResult.OK)
                {
                    EditBook?.Invoke(EditBookForm.OldName, EditBookForm.NewName);
                }
            }
        }

        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                string selectedBook = BookList.SelectedItem.ToString();
                DeleteBook?.Invoke(selectedBook);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML?.Invoke(this, EventArgs.Empty);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXML?.Invoke(this, EventArgs.Empty);
        }

        private void Filtre_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.Checked == true)
            {
                if (AuthotComboBox.SelectedItem != null)
                {
                    Filter?.Invoke(AuthotComboBox.SelectedItem.ToString());
                }
            }
            else
            {
                Filter?.Invoke(null);
            }
        }

        private void AuthotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filtre.Checked == true)
            {
                if (AuthotComboBox.SelectedItem != null)
                {
                    Filter?.Invoke(AuthotComboBox.SelectedItem.ToString());
                }
            }
        }

        public void DisplayError(string message) // вывод ошибок
        {
            MessageBox.Show(message, "Authors and books");
        }
    }
}