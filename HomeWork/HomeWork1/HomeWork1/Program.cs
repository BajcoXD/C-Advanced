using HomeWork1.Entities.Models;

Searchable doc = new Document("This is a sample document containing various words.");
Searchable page = new WebPage("I know who Viktor is!");

string keyword = "Viktor";

Console.WriteLine($"Keyword '{keyword}' found in document? {doc.Search(keyword)}");
Console.WriteLine($"Keyword '{keyword}' found in webpage? {page.Search(keyword)}");