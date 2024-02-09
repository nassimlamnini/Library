using System;
using System.Collections.Generic;

public class Review : Document
{
    public int Month { get; private set; }
    public int Year { get; private set; }

    // Constructor
    public Review(int id, string title, int numberOfPages, string publisher, int month, int year)
        : base(id, title, numberOfPages, publisher)
    {
        Month = month;
        Year = year;
    }

    // Accessors
    public void SetMonth(int month) => Month = month;
    public int GetMonth() => Month;

    public void SetYear(int year) => Year = year;
    public int GetYear() => Year;

    // ToString method override
    public override string ToString()
    {
        return base.ToString() + $", Month: {Month}, Year: {Year}";
    }
}