using System;
using System.Collections.Generic;

public class Book : Document
{
    public string Author { get; private set; }

    public Book(int id, string title, int numberOfPages, string publisher, string author)
        : base(id, title, numberOfPages, publisher)
    {
        Author = author;
    }

    public override string ToString()
    {
        return base.ToString() + $", Author: {Author}";
    }
}