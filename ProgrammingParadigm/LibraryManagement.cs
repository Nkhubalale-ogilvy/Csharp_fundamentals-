namespace ProgrammingParadigm;

public class Book(string title, string author)
{
    private readonly string _title = title;
    private readonly string _author = author;

    private bool _isCheckedOut = false;

    public string Title => _title;
    public string Author => _author;

    public bool CheckOut()
    {
        if (!_isCheckedOut)
        {
            _isCheckedOut = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ReturnBook()
    {
        if (_isCheckedOut)
        {
            _isCheckedOut = false;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsAvailable()
    {
        return !_isCheckedOut;
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


    