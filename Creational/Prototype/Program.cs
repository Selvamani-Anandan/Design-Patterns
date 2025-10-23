using Prototype;

// Create prototype instances
var textDoc = new TextDocument(
    "Meeting Notes",
    "Discussion points for the next sprint planning",
    "John Doe",
    "Calibri",
    11
);

var spreadsheetDoc = new SpreadsheetDocument(
    "Q4 Budget",
    "Financial projections for Q4",
    "Jane Smith",
    20,
    8
);

// Create and setup the registry
var registry = new DocumentRegistry();
registry.RegisterDocument("text", textDoc);
registry.RegisterDocument("spreadsheet", spreadsheetDoc);

// Clone and customize documents
Console.WriteLine("Prototype Pattern Demonstration");
Console.WriteLine("==============================");

// Clone a text document
var clonedText = registry.CreateClone("text");
clonedText.Display();

// Clone a spreadsheet
var clonedSpreadsheet = registry.CreateClone("spreadsheet");
clonedSpreadsheet.Display();

// Clone and modify
var customTextDoc = registry.CreateClone("text");
customTextDoc.Title = "Team Meeting Notes";
customTextDoc.Content = "Updated content for team meeting";
customTextDoc.Display();