using System;
using System.Collections.Generic;


public class Document
{

    public int ID { get; private set; }
    public string Title { get; private set; }
    public int NumberOfPages { get; private set; }
    public string Publisher { get; private set; }

    // Constructor
    public Document(int id, string title, int numberOfPages, string publisher)
    {
        ID = id;
        Title = title;
        NumberOfPages = numberOfPages;
        Publisher = publisher;
    }

    // ToString method override
    public override string ToString()
    {
        return $"Document ID: {ID}, Title: {Title}, Pages: {NumberOfPages}, Publisher: {Publisher}";
    }
}
