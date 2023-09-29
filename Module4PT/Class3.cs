using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author}, Published in {Year}";
    }
}

class HomeLibrary
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public bool RemoveBook(string title)
    {
        Book bookToRemove = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            return true;
        }
        return false;
    }

    public List<Book> SearchBooksByAuthor(string author)
    {
        return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> SearchBooksByYear(int year)
    {
        return books.Where(b => b.Year == year).ToList();
    }

    public void SortBooksByTitle()
    {
        books = books.OrderBy(b => b.Title).ToList();
    }

    public void SortBooksByAuthor()
    {
        books = books.OrderBy(b => b.Author).ToList();
    }

    public void SortBooksByYear()
    {
        books = books.OrderBy(b => b.Year).ToList();
    }

    public void DisplayBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {
        HomeLibrary library = new HomeLibrary();

        Book book1 = new Book { Title = "Book1", Author = "Author1", Year = 2000 };
        Book book2 = new Book { Title = "Book2", Author = "Author2", Year = 1995 };
        Book book3 = new Book { Title = "Book3", Author = "Author1", Year = 2010 };

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("All Books:");
        library.DisplayBooks();

        Console.WriteLine("\nBooks by Author1:");
        List<Book> booksByAuthor = library.SearchBooksByAuthor("Author1");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nBooks from 2000:");
        List<Book> booksFrom2000 = library.SearchBooksByYear(2000);
        foreach (var book in booksFrom2000)
        {
            Console.WriteLine(book);
        }

        library.SortBooksByTitle();
        Console.WriteLine("\nBooks Sorted by Title:");
        library.DisplayBooks();

        library.SortBooksByAuthor();
        Console.WriteLine("\nBooks Sorted by Author:");
        library.DisplayBooks();

        library.SortBooksByYear();
        Console.WriteLine("\nBooks Sorted by Year:");
        library.DisplayBooks();

        Console.ReadLine();
    }
}
