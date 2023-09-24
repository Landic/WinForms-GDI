using static System.Reflection.Metadata.BlobBuilder;

namespace Volkov_HW_3
{
    public partial class Form1 : Form, IAutorBooksView
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        void IAutorBooksView.DisplayAuthors(List<string> authors) // вывод всех авторов нужно дл€ обновление информации
        {
            AuthotComboBox.Items.Clear();
            foreach (var author in authors)
            {
                AuthotComboBox.Items.Add(author);
            }
            if (AuthotComboBox.Items.Count > 0)
            {
                AuthotComboBox.SelectedIndex = 0;
            }
        }

        void IAutorBooksView.DisplayBooks(List<string> books) // вывод всех книг нужно дл€ обновление информации
        {
            BookList.Items.Clear();
            foreach (var i in books)
            {
                BookList.Items.Add(i);
            }
        }

        void IAutorBooksView.DisplayFilteredBooks(List<string> books) // фильтраци€ 
        {
            BookList.Items.Clear();
            foreach (var i in books)
            {
                BookList.Items.Add(i);
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
                    AddBook?.Invoke(AuthotComboBox.SelectedItem.ToString(), AddBooksForm.BooksName);
                }
            }
        }

        private void DeleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthotComboBox.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("¬ы уверены что хотите удалить автора?", "Authors and books", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    string selectedAuthor = AuthotComboBox.SelectedItem.ToString();
                    DeleteAuthor?.Invoke(selectedAuthor);
                }
                
            }
        }

        private void EditAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var EditAuthorForm = new EditAuthorForm())
            {
                if (EditAuthorForm.ShowDialog() == DialogResult.OK)
                {
                    EditAuthor?.Invoke(AuthotComboBox.SelectedItem.ToString(), EditAuthorForm.NewAuthor);
                }
            }
        }

        private void EditBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var EditBookForm = new EditBookForm())
            {
                if (EditBookForm.ShowDialog() == DialogResult.OK)
                {
                    EditBook?.Invoke(BookList.SelectedItem.ToString(), EditBookForm.NewName);
                }
            }
        }

        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("¬ы уверены что хотите удалить книгу?", "Authors and books", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedBook = BookList.SelectedItem.ToString();
                    DeleteBook?.Invoke(selectedBook);
                }
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