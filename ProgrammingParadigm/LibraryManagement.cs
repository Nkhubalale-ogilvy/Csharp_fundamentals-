namespace ProgrammingParadigm;

public class Book(string title, string author)
{
    private readonly string _title = title;
    private readonly string _author = author;

    private bool IsCheckOut = false;

    public string Title => _title;
    public string Author => _author;

    public bool CheckOut()
    {
        if (!IsCheckOut)
        {
            IsCheckOut = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ReturnBook()
    {
        if (IsCheckOut)
        {
            IsCheckOut = false;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsAvailable()
    {
        return !IsCheckOut;
    }

}

public class Library
{
    private List<Book> _books = new();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public string CheckOutBook(string title)
    {
        foreach (var book in _books)
        {
            if (book.Title == title)
            {
                if (book.IsAvailable())
                {
                    book.CheckOut();
                    return $"Checked out '{title}'";
                }
                else
                {
                    return $"'{title}' is already checked out";
                }
            }
        }
        return $"'{title}' not found in the library";
    }
    public string ReturnBook(string title)
    {
        foreach (var book in _books)
        {
            if (book.Title == title)
            {
                if (!book.IsAvailable())
                {
                    book.ReturnBook();
                    return $"Returned '{title}'";
                }
                else
                {
                    return $"'{title}' was not checked out";
                }
            }
        }
        return $"'{title}' not found in the library";
    }

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in _books)
        {
            if (book.IsAvailable())
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }   

}


    