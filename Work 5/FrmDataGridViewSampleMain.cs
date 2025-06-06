using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work5
{
    public partial class FrmDataGridViewSampleMain : Form
    {
        private List<Book> books = new List<Book>();
        private bool cancelContextMenu = false;
        public FrmDataGridViewSampleMain()
        {
            InitializeComponent();
        }

        private void InitTestBooksData()
        {
            books.Add(new Book("Война и мир", "Лев Николаевич Толстой", DateTime.Parse("1867-01-01")));
            books.Add(new Book("Анна Каренина", "Лев Николаевич Толстой",DateTime.Parse("1877-01-01")));
            books.Add(new Book("После бала", "Лев Николаевич Толстой", DateTime.Parse("1911-01-01")));
            books.Add(new Book("Юность", "Лев Николаевич Толстой", DateTime.Parse("1857-01-01")));
            books.Add(new Book("Кавказский пленник", "Лев Николаевич Толстой", DateTime.Parse("1872 - 01 - 01"))); 
            books.Add(new Book("Преступление и наказание", "Фёдор Михайлович Достоевский", DateTime.Parse("1866 - 01 - 01")));
            books.Add(new Book("Евгений Онегин", "Александр Сергеевич Пушкин", DateTime.Parse("1833 - 01 - 01")));
            books.Add(new Book("Капитанская дочка", "Александр Сергеевич Пушкин", DateTime.Parse("1836 - 01 - 01")));
            books.Add(new Book("Руслан и Людмила", "Александр Сергеевич Пушкин", DateTime.Parse("1820 - 01 - 01")));     
            books.Add(new Book("Метель", "Александр Сергеевич Пушкин", DateTime.Parse("1831-01-01")));
            books.Add(new Book("Пиковая дама", "Александр Сергеевич Пушкин", DateTime.Parse("1834-01-01")));
            books.Add(new Book("Мать", "Максим Горький", DateTime.Parse("1906-01-01")));
            books.Add(new Book("Мёртвые души", "Николай Васильевич Гоголь", DateTime.Parse("1842-01-01")));
            books.Add(new Book("Шинель", "Николай Васильевич Гоголь", DateTime.Parse("1842-01-01")));
            books.Add(new Book("Тарас Бульба", "Николай Васильевич Гоголь", DateTime.Parse("1835-01-01")));
            books.Add(new Book("Нос", "Николай Васильевич Гоголь", DateTime.Parse("1836-01-01")));
            books.Add(new Book("Вечера на хуторе близ Диканьки", "Николай Васильевич Гоголь", DateTime.Parse("1830 - 01 - 01")));
            books.Add(new Book("Ночь перед рождеством", "Николай Васильевич Гоголь", DateTime.Parse("1832 - 01 - 01")));
            books.Add(new Book("Вий", "Николай Васильевич Гоголь", DateTime.Parse("1835-01-01")));
            books.Add(new Book("Повесть о капитане Копейкине", "Николай Васильевич Гоголь", DateTime.Parse("1842 - 01 - 01")));
            books.Add(new Book("Заколдованное место", "Николай Васильевич Гоголь", DateTime.Parse("1832 - 01 - 01"))); 
            books.Add(new Book("Портрет", "Николай Васильевич Гоголь", DateTime.Parse("1835-01-01")));
            books.Add(new Book("Тихий Дон", "Михаил Александрович Шолохов", DateTime.Parse("1928-01-01")));
        }

        private List<Book> GetFilteredBooks()
        {
            List<Book> result = new List<Book>();

            string searchString = TextBoxSearch.Text;
            if (searchString.Length == 0)
            {
                return books;
            }
            searchString = searchString.ToLower();
            foreach (Book book in books)
            {
                if ((book.Title.Length > 0 &&
               book.Title.ToLower().Contains(searchString)) || (book.Author.Length > 0 &&
               book.Author.ToLower().Contains(searchString)) || (book.YearPublished.Length > 0 &&
               book.YearPublished.Contains(searchString)))
                {
                    result.Add(book);
                }
            }
            return result;
        }

        private void RefreshDataGridView()
        {
            DataGridViewBooks.DataSource = null;
            DataGridViewBooks.DataSource = GetFilteredBooks();
            DataGridViewBooks.Columns["Title"].HeaderText = "Название";
            DataGridViewBooks.Columns["Title"].Width = 200;
            DataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            DataGridViewBooks.Columns["Author"].Width = 200;
            DataGridViewBooks.Columns["DatePublished"].HeaderText = "Дата издания";
            DataGridViewBooks.Columns["DatePublished"].Width = 200;
            DataGridViewBooks.Columns["DatePublished"].Visible = false;
            DataGridViewBooks.Columns["YearPublished"].HeaderText = "Год публикации";
            DataGridViewBooks.Columns["YearPublished"].Width = 126;
        }

        private void UpdateBooksListDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Books: [\r\n");
            foreach (Book b in books)
            {
                sb.Append(b.ToString());
                sb.Append("\r\n");
            }
            sb.Append("]");
            TextBoxBooks.Text = sb.ToString();
        }

        private void RefreshGridAndBookDetails()
        {
            RefreshDataGridView();
            UpdateBooksListDetails();
        }

        private void UpdateButtonAddBookState()
        {
            ButtonAddBook.Enabled = TextBoxTitle.Text.Length > 0 && TextBoxAuthor.Text.Length > 0;
        }

        private void FrmDataGridViewSampleMain_Load(object sender, EventArgs e)
        {
            InitTestBooksData();
            RefreshGridAndBookDetails();
            UpdateButtonAddBookState();
        }
    }
}
