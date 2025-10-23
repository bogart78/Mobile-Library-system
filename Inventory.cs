public class Book
{
    public string SerialCode { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string serial, string title)
    {
        SerialCode = serial;
        Title = title;
        IsBorrowed = false;
    }
}

public class Inventory
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book FindBook(string serial)
    {
        return books.Find(b => b.SerialCode == serial);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\nBook Inventory:");
        foreach (var book in books)
        {
            string status = book.IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"{book.SerialCode} - {book.Title} ({status})");
        }
    }
}