using ConsoleApp1.Models;

ISearchable doc = new Document("This is a sample document about C# interfaces.");
ISearchable page = new WebPage("<html><body>This is a web page about C# programming.</body></html>");

Console.WriteLine($"Found in document: {doc.Search("interfaces")}");
Console.WriteLine($"Found in webpage: {page.Search("programming")}");
Console.WriteLine($"Found in document (fail): {doc.Search("Java")}");