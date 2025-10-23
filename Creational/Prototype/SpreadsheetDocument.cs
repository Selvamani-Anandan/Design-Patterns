namespace Prototype;

public class SpreadsheetDocument : IDocument
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Author { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public SpreadsheetDocument(string title, string content, string author, int rows = 10, int columns = 5)
    {
        Title = title;
        Content = content;
        Author = author;
        CreatedDate = DateTime.Now;
        RowCount = rows;
        ColumnCount = columns;
    }

    public IDocument Clone()
    {
        // Create a new instance with the same properties
        return new SpreadsheetDocument(
            Title + " (Copy)",
            Content,
            Author)
        {
            CreatedDate = DateTime.Now,
            RowCount = this.RowCount,
            ColumnCount = this.ColumnCount
        };
    }

    public void Display()
    {
        Console.WriteLine("\nSpreadsheet Document:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Created: {CreatedDate}");
        Console.WriteLine($"Size: {RowCount} rows x {ColumnCount} columns");
        Console.WriteLine($"Content: {Content}");
    }
}