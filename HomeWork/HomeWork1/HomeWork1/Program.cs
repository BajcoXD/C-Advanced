using HomeWork1.Entities.Models;

Searchable doc = new Document("This is a sample document containing various words.");
Searchable page = new WebPage("<html><body>Welcome to our webpage about technology and science.</body></html>");

string keyword = "technology";

Console.WriteLine($"Keyword '{keyword}' found in document? {doc.Search(keyword)}");
Console.WriteLine($"Keyword '{keyword}' found in webpage? {page.Search(keyword)}");