using System;
using System.Collections.Generic;
using System.Linq;

public class Shelf
{
    private List<Document> documents;

    // This constructor remains the same.
    public Shelf()
    {
        documents = new List<Document>();
    }

    // AddDocument method remains the same.
    public void AddDocument(Document document)
    {
        documents.Add(document);
    }

    // This is the new property to expose the documents list.
    public List<Document> Documents
    {
        get { return documents; }
    }

    // FindBookByAuthor method remains the same.
    public Book FindBookByAuthor(string author)
    {
        return documents.OfType<Book>().FirstOrDefault(book => book.Author == author);
    }

    // ListDocuments method remains the same.
    public string ListDocuments()
    {
        return string.Join("\n", documents.Select(doc => doc.ToString()));
    }
}


