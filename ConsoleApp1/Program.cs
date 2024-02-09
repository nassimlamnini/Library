using System;

class Program
{
    static void Main()
    {
        // Create a library with a maximum of 5 books per shelf
        Library library = new Library(5);
        library.AddShelf(); // Add a shelf to the library

        // Create some documents and add them to the library
        Document doc = new Document(1, "The Great Gatsby", 218, "Charles Scribner's Sons");
        Book book = new Book(2, "Nineteen Eighty-Four", 328, "Secker & Warburg", "George Orwell");
        Novel novel = new Novel(3, "Pride and Prejudice", 432, "T. Egerton", "Jane Austen", "Best Novel Award");
        Manual manual = new Manual(4, "Calculus Early Transcendentals", 1200, "Stewart", "James Stewart", 1);

        // Try adding documents to the library
        library.AddBookToShelf(doc);  
        library.AddBookToShelf(book);
        library.AddBookToShelf(novel);
        library.AddBookToShelf(manual);

        // Search for a document by title
        Document searchResult = library.SearchForDocument("Nineteen Eighty-Four");
        if (searchResult != null)
        {
            Console.WriteLine("Document found: " + searchResult.ToString());
        }
        else
        {
            Console.WriteLine("Document not found.");
        }

        // List documents in the library
        Console.WriteLine("\nDocuments in the library:");
        foreach (var shelf in library.Shelves) // Assuming there is a public property Shelves that exposes the list of shelves
        {
            Console.WriteLine(shelf.ListDocuments());
        }

        // Find a book by author
        Book bookByAuthor = library.FindBookByAuthor("Jane Austen"); // Assuming this method is implemented in the Library class
        if (bookByAuthor != null)
        {
            Console.WriteLine("\nBook found by author: " + bookByAuthor.ToString());
        }
        else
        {
            Console.WriteLine("Book by the author not found.");
        }
    }
}
