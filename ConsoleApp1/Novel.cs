using System;
using System.Collections.Generic;

public class Novel : Book
{
    public string LiteraryPrize { get; private set; }

    public Novel(int id, string title, int numberOfPages, string publisher, string author, string literaryPrize)
        : base(id, title, numberOfPages, publisher, author)
    {
        LiteraryPrize = literaryPrize;
    }

    public override string ToString()
    {
        return base.ToString() + (string.IsNullOrEmpty(LiteraryPrize) ? "" : $", Literary Prize: {LiteraryPrize}");
    }
}