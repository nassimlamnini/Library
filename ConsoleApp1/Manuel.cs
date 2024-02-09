using System;
using System.Collections.Generic;


public class Manual : Book
{
    public int SchoolLevel { get; private set; }

    // Constructor
    public Manual(int id, string title, int numberOfPages, string publisher, string author, int schoolLevel)
        : base(id, title, numberOfPages, publisher, author)
    {
        SchoolLevel = schoolLevel;
    }

    // ToString method override to include school level
    public override string ToString()
    {
        return $"{base.ToString()}, School Level: {SchoolLevel}";
    }
}
