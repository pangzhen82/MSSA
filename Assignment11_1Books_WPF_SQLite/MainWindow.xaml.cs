using Assignment11_1Books_WPF_SQLite.Data;
using System.Net.Http.Headers;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment11_1Books_WPF_SQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookContext _dbContext;
        Book _newBook = new Book();
        Book? _selectedBook = new Book();

        public MainWindow(BookContext _dbContext)
        {
            this._dbContext = _dbContext;
            InitializeComponent();
            GetBooks();
            AddBookGrid.DataContext = _newBook;
        }
        private void GetBooks()
        {
            BooksDataGrid.ItemsSource = this._dbContext.Books.ToList();
        }
        private void UpdateBookForEdit (object sender, RoutedEventArgs e)
        {
            _selectedBook = (sender as FrameworkElement).DataContext as Book;
            UpdateBookGrid.DataContext = _selectedBook;
        }
        private void DeleteBook (object sender, RoutedEventArgs e)
        {
            var book = (sender as FrameworkElement).DataContext as Book;
            this._dbContext.Books.Remove(book);
            this._dbContext.SaveChanges();
            GetBooks();
        }
        private void AddBook (object sender, RoutedEventArgs e)
        {
            this._dbContext.Books.Add(_newBook);
            this._dbContext.SaveChanges();
            GetBooks();
            _newBook = new Book();
            AddBookGrid.DataContext= _newBook;
        }
        private void UpdateBook (object sender, RoutedEventArgs e)
        {
            this._dbContext.Books.Update(_selectedBook);
            this._dbContext.SaveChanges();
            _selectedBook = null;
            UpdateBookGrid.DataContext = _selectedBook;
            GetBooks();
        }
    }
}