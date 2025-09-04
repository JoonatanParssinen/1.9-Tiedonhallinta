namespace Eka_Takasin;

public class Book
{
    public string author_name { get; set; }
    public string book_name { get; set; }
    public string release_year { get; set; }
    public string genre { get; set; }

    public Book(string authorName, string bookName, string releaseYear, string genre)
    {
        this.author_name = authorName;
        this.book_name = bookName;
        this.release_year = releaseYear;
        this.genre = genre;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Author Name: {this.author_name}, Book Name: {this.book_name}, Releas Year: {this.release_year}, Genre: {genre}";
    }
}