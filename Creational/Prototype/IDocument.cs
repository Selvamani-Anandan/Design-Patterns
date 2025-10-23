namespace Prototype;

/// <summary>
/// The prototype interface that declares the cloning method
/// </summary>
public interface IDocument
{
    string Title { get; set; }
    string Content { get; set; }
    DateTime CreatedDate { get; set; }
    string Author { get; set; }
    
    // The clone method
    IDocument Clone();
    
    // Method to display document info
    void Display();
}