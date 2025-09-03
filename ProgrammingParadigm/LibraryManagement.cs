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


    public static void RunProgram()
    {
        Console.WriteLine("Library Management System");

        // new instance of the library class
        Library library = new();

        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
        library.AddBook(new Book("1984", "George Orwell"));

        Console.WriteLine("Welcome to the Library! We've added some sample books to get started.");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nLibrary Operations:");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Check Out a Book");
            Console.WriteLine("3. Return a Book");
            Console.WriteLine("4. Display Available Books");
            Console.WriteLine("5. Return to Main Menu");
            Console.Write("Enter your choice (1-5): ");
            
            string? operation = Console.ReadLine();
            
            switch (operation)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string? title = Console.ReadLine();
                    
                    Console.Write("Enter author name: ");
                    string? author = Console.ReadLine();
                    
                    if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
                    {
                        library.AddBook(new Book(title, author));
                        Console.WriteLine($"Added: '{title}' by {author}");
                    }
                    else
                    {
                        Console.WriteLine("Book title and author cannot be empty.");
                    }
                    break;
                    
                case "2":
                    Console.Write("Enter the title of the book you want to check out: ");
                    string? checkoutTitle = Console.ReadLine();
                    
                    if (!string.IsNullOrEmpty(checkoutTitle))
                    {
                        string result = library.CheckOutBook(checkoutTitle);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Book title cannot be empty.");
                    }
                    break;
                    
                case "3":
                    Console.Write("Enter the title of the book you want to return: ");
                    string? returnTitle = Console.ReadLine();
                    
                    if (!string.IsNullOrEmpty(returnTitle))
                    {
                        string result = library.ReturnBook(returnTitle);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Book title cannot be empty.");
                    }
                    break;
                    
                case "4":
                    library.DisplayAvailableBooks();
                    break;
                    
                case "5":
                    exit = true;
                    Console.WriteLine("Returning to main menu...");
                    break;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        }

}

    