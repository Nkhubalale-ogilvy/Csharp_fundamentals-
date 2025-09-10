public class Books
{
    public string title;
    public string author;

    public Books(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public override string ToString()
    {
        return $"{title} by {author}";
    }
}


public class EBooks : Books
{
    public double fileSizeMB;
    public EBooks(string title, string author, double fileSizeMB) : base(title, author)
    {
        this.fileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return $"EBook: {base.title} by {base.author}, File Size: {fileSizeMB} MB";

    }
}

public class PrintBooks : Books
{
    public double page_count;

    public PrintBooks(string title, string author, double page_count) : base(title, author)
    {
        this.page_count = page_count;
    }

    public override string ToString()
    {
        return $"Print Book: {base.title} by {base.author}, Page Count: {page_count} pages";

    }
}


public class Library
{
    public List<Books> books;

    public Library()
    {
        books = new List<Books>();
    }

    public void AddBook(Books book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}


public class LibrarySystem
{
    public static void RunDemo()
    {
        Library library = new Library();
        Books classicBook = new Books("Pride and Prejudice", "Jane Austen");
        EBooks digitalNovel = new EBooks("Snow Crash", "Neal Stephenson", 500);
        PrintBooks paperNovel = new PrintBooks("The Catcher in the Rye", "J.D. Salinger", 234);

        library.AddBook(classicBook);
        library.AddBook(digitalNovel);
        library.AddBook(paperNovel);


        library.DisplayBooks();
    }


}