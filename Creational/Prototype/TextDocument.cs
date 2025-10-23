namespace Prototype;

public class TextDocument : IDocument
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Author { get; set; }
    public string FontName { get; set; }
    public int FontSize { get; set; }

    public TextDocument(string title, string content, string author, string fontName = "Arial", int fontSize = 12)
    {
        Title = title;
        Content = content;
        Author = author;
        CreatedDate = DateTime.Now;
        FontName = fontName;
        FontSize = fontSize;
    }

    public IDocument Clone()
    {
        // Create a new instance with the same properties
        return new TextDocument(
            Title + " (Copy)",
            Content,
            Author)
        {
            CreatedDate = DateTime.Now,
            FontName = this.FontName,
            FontSize = this.FontSize
        };
    }

    public void Display()
    {
        Console.WriteLine("\nText Document:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Created: {CreatedDate}");
        Console.WriteLine($"Font: {FontName}, Size: {FontSize}");
        Console.WriteLine($"Content: {Content}");
    }
}