namespace Eka_Takasin;

using Eka_Takasin;
class Program
{
    static Library bookLibrary = new Library();
    static void Main(string[] args)
    {
        List<string> aRetunerBook = new List<string>();
        List<string> books = new List<string>();
        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1) Add a book");
            Console.WriteLine("2) Remove a book");
            Console.WriteLine("3) List of all books");
            Console.WriteLine("4) List of books from a genre");
            Console.WriteLine("5) List of books from a author's name");
            Console.WriteLine("6) List of books from a book's name");
            Console.WriteLine("7) Exit Program ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    bookLibrary.removeBook();
                    break;
                case "3":
                    List<Book> loopList = bookLibrary.returnAllBooks();
                    foreach (Book book in loopList)
                    {
                        Console.WriteLine(book);
                    }
                    break;
                case "4":
                    Console.WriteLine("What Genre?");
                    string inputGenre = Console.ReadLine();
                    List<Book> GloopList = bookLibrary.searchGenre(inputGenre);
                    foreach (Book book in GloopList)
                    {
                        Console.WriteLine(book);
                    }
                    break;
                case "5":
                    Console.WriteLine("Who's Author?");
                    string inputAuthor = Console.ReadLine();
                    List<Book> AloopList = bookLibrary.searchAuthor(inputAuthor);
                    foreach (Book book in AloopList)
                    {
                        Console.WriteLine(book);
                    }
                    break;
                case "6":
                    Console.WriteLine("What Book?");
                    string inputBook = Console.ReadLine();
                    List<Book> BloopList = bookLibrary.searchBook(inputBook);
                    foreach (Book book in BloopList)
                    {
                        Console.WriteLine(book);
                    }
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("Authors name?");
        string author_name = Console.ReadLine();
        Console.WriteLine("Book name?");
        string book_name = Console.ReadLine();
        Console.WriteLine("What is the release year?");
        string release_year = Console.ReadLine();
        Console.WriteLine("What's the genre?");
        string genre = Console.ReadLine();

        bookLibrary.BookAdd(author_name, book_name, release_year, genre);
    }

}
