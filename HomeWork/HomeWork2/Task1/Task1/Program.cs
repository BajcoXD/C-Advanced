using Task1.Entities.Models;

Console.WriteLine("Search by Id:");
Console.WriteLine(UserDatabase.SearchById(2));

Console.WriteLine("\nSearch by Name:");
UserDatabase.PrintUsers(UserDatabase.SearchByName("alice"));

Console.WriteLine("\nSearch by Age:");
UserDatabase.PrintUsers(UserDatabase.SearchByAge(25));