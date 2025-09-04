using System.ComponentModel;

namespace Eka_Takasin;

public class Library
{
    List<Book> books = new();

    public void BookAdd(string author, string book_name, string release_year, string genre)
    {
        books.Add(new Book(author, book_name, release_year, genre));
    }

    public List<Book> returnAllBooks()
    {
        return books;
    }

    public List<Book> removeBook()
    {
        books.RemoveAt(books.Count - 1);
        return books;
    }

    public List<Book> searchGenre(string inputGenre)
    {
        List<Book> genreBooks = new();
        foreach (Book book in books)
        {
            if (book.genre == inputGenre)
            {
                genreBooks.Add(book);
            }
        }
        return genreBooks;
    }

    public List<Book> searchAuthor(string inputAuthor)
    {
        List<Book> authorBooks = new();
        foreach (Book book in books)
        {
            if (book.author_name == inputAuthor)
            {
                authorBooks.Add(book);
            }
        }
        return authorBooks;
    }
    
    public List<Book> searchBook(string inputBook)
    {
        List<Book> bookBooks = new();
        foreach (Book book in books)
        {
            if (book.book_name == inputBook)
            {
                bookBooks.Add(book);
            }   
        }
        return bookBooks;
    }
}