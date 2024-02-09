using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Shelf> shelves;
    private int maxBooksPerShelf;

    public Library(int maxBooksPerShelf)
    {
        this.maxBooksPerShelf = maxBooksPerShelf;
        shelves = new List<Shelf>();
    }

    public void AddShelf()
    {
        shelves.Add(new Shelf());
    }

    public bool AddBookToShelf(Document document) // Now accepts Document, not just Book
    {
        foreach (var shelf in shelves)
        {
            if (shelf.Documents.Count < maxBooksPerShelf)
            {
                shelf.AddDocument(document);
                return true;
            }
        }
        return false;
    }

    public Document SearchForDocument(string title)
    {
        foreach (var shelf in shelves)
        {
            var document = shelf.Documents.FirstOrDefault(doc => doc.Title == title);
            if (document != null)
            {
                return document;
            }
        }
        return null;
    }

    // New public property to expose the list of shelves
    public List<Shelf> Shelves
    {
        get { return shelves; }
    }

    // Method to find a book by the author
    public Book FindBookByAuthor(string author)
    {
        foreach (var shelf in shelves)
        {
            var book = shelf.FindBookByAuthor(author);
            if (book != null)
            {
                return book;
            }
        }
        return null;
    }
}
