namespace Practice2.LibrarySystem
{
    public class Library
    {
        private readonly List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public void RemoveBook(string bookIsbn)
        {
            _books.RemoveAll(book => book.ISBN == bookIsbn);
        }

        public void DisplayBooks()
        {
            _books.ForEach(book => book.DisplayDetails());
        }
    }
}
