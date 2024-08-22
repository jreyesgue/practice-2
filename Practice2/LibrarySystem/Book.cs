namespace Practice2.LibrarySystem
{
    public class Book
    {
        public string ISBN { get; init; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"--- Book {ISBN} ---");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }
}
