using System;
class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public float Rating;
    public Book(string t, string a, string g, float r)
    {
        Title = t;
        Author = a;
        Genre = g;
        Rating = r;
    }
    public Book(Book b)
    {
        Title = b.Title;
        Author = b.Author;
        Genre = b.Genre;
        Rating = b.Rating;
    }
}
class Program
{
    static void Main()
    {
        Book[] books = new Book[5];
        books[0] = new Book("Atomic Habits", "James Clear", "Self Help", 4.8f);
        books[1] = new Book("Deep Work", "Cal Newport", "Self Help", 4.7f);
        books[2] = new Book("Mindset", "Carol Dweck", "Self Help", 4.6f);
        books[3] = new Book("Harry Potter", "J.K Rowling", "Fantasy", 4.4f);
        books[4] = new Book("Clean Code", "Robert Martin", "Programming", 4.5f);
        Console.WriteLine("--- LIBRARY SYSTEM STARTED ---");
        Console.WriteLine("Top Rated Books:");
        for (int i = 0; i < 5; i++)
        {
            if (books[i].Rating > 4.5)
            {
                Console.WriteLine(books[i].Title + " (Rating: " + books[i].Rating + ")");
            }
        }
        Console.WriteLine("Search Genre: Self Help");
        Console.WriteLine("Results:");
        for (int i = 0; i < 5; i++)
        {
            if (books[i].Genre == "Self Help")
            {
                Console.WriteLine(books[i].Title);
            }
        }
        float max = 0;
        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            if (books[i].Rating > max)
            {
                max = books[i].Rating;
                index = i;
            }
        }
        Book recommended = new Book(books[index]);
        Console.WriteLine("Recommended Book Added:");
        Console.WriteLine(recommended.Title);
        Console.WriteLine("--- LIBRARY REPORT COMPLETE ---");
    }
}
