public class Book
{
    private string _title;
    private string _author;
    private int _year;

    public Book(string title, string author, int year)
    {
        _title = title;
        _author = author;
        _year = year;
    }

    ~Book()
    {
        Console.WriteLine($"Deleting {_title}");
    }


    public override string ToString()
    {
        return $"{_title} by {_author}, published in {_year}";
    }


}

public class RunBook
{
    public static void Run()
    {
        Book book = new("1984", "George Orwell", 1949);
        Console.WriteLine(book.ToString());
        Console.WriteLine(book);

        book = null;
        GC.Collect(); // Forces immediate garbage collection 
        GC.WaitForPendingFinalizers(); // Waits for the finalizer to complete ( destructor (~Book) must run)

        Console.WriteLine(book);
        Console.WriteLine("The empty line above is because book is now null");
        
    }
}   