using Practice2.Utils;

namespace Practice2.LibrarySystem
{
    public class LibraryMenu
    {
        private readonly Library _library;

        public LibraryMenu()
        {
            _library = new Library();
        }

        public void StartMenu()
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (ConsoleReader.GetOption())
                {
                    case 1:
                        CreateBook();
                        break;
                    case 2:
                        DeleteBook();
                        break;
                    case 3:
                        Console.WriteLine();
                        _library.DisplayBooks();
                        break;
                    case 4:
                        Console.WriteLine("\nReturning to main menu...\n");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.");
                        break;
                }
            } while (!finish);
        }

        private void CreateBook()
        {
            Console.Write("\nEnter the book ISBN: ");
            string bookIsbn = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter the book title: ");
            string bookTitle = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter the book author: ");
            string bookAuthor = Console.ReadLine() ?? string.Empty;

            _library.AddBook(new Book(bookIsbn, bookTitle, bookAuthor));
        }

        private void DeleteBook()
        {
            Console.Write("\nEnter the book ISBN: ");
            string deleteBookIsbn = Console.ReadLine() ?? string.Empty;

            _library.RemoveBook(deleteBookIsbn);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- Library Menu ---\n");
            Console.WriteLine("1. Add book.");
            Console.WriteLine("2. Remove book.");
            Console.WriteLine("3. Display books.");
            Console.WriteLine("4. Exit.");
        }
    }
}
