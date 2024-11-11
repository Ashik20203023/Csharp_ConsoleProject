using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsBorrow { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(string title) // Added opening brace
    {
        var book = new Book
        {
            Id = books.Count + 1,
            Title = title,
            IsBorrow = false
        };
        books.Add(book); 
        Console.WriteLine($"Book '{title}' added to library.");
    }
    public void BorrowBook(int bookId)
    {
        var book = books.FirstOrDefault(b => b.Id == bookId && !b.IsBorrow);
        if (book != null)
        {
            book.IsBorrow = true;
            Console.WriteLine($"Book '{book.Title}' borrowed.");
        }
        else
        {
            Console.WriteLine("this book is not available");
        }
    }
    public void ReturnBook(int bookId)
    {
        var book = books.FirstOrDefault(b => b.Id==bookId && !b.IsBorrow);
        if (book != null)
        {
            book.IsBorrow = false;
            Console.WriteLine($"Book '{ book.Title}'Returned ");
        }
        else
        {
            Console.WriteLine(" Book was not borrowed or does not exist.");
        }
    }
    public void SearchBook(string title)
    {
        var FoundBooks = books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        if (FoundBooks.Any())
        {
            Console.WriteLine("The book is found");
            foreach (var book in FoundBooks)
            {
                Console.WriteLine($"{book.Id}: {book.Title} - {(book.IsBorrow ? "Borrowed" : "Available")} ");
            }
        }
        else
        {
            Console.WriteLine("No books Found");
        }
        


    }
}
class program
{
    static void Main()
    {
        Library obj= new Library();
        obj.AddBook("C# Programming");
        obj.AddBook("Algorithm");

        obj.SearchBook("C#");    // Searches for books with "C#" in the title.
        obj.BorrowBook(1);       // Borrows the book with ID 1.
        obj.SearchBook("C#");    // Searches again to show updated status.
        obj.ReturnBook(1);       // Returns the book with ID 1.
        obj.SearchBook("C#");

    }
}
