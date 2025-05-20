using app.Models;

var people = new List<Person>
{
    new Person { FirstName = "Freddy", Age = 32, Dogs = new List<Dog> {
        new Dog { Name = "Barky", Age = 2, Color = "white" },
        new Dog { Name = "Max", Age = 4, Color = "brown" },
        new Dog { Name = "Bolt", Age = 5, Color = "black" }
    }},
    new Person { FirstName = "Rachel", Age = 27, Dogs = new List<Dog> {
        new Dog { Name = "Shadow", Age = 6, Color = "brown" }
    }},
    new Person { FirstName = "Cristofer", Age = 40, Dogs = new List<Dog> {
        new Dog { Name = "Snow", Age = 3, Color = "white" }
    }},
    new Person { FirstName = "Erin", Age = 29, Dogs = new List<Dog> {
        new Dog { Name = "Ghost", Age = 1, Color = "white" }
    }},
    new Person { FirstName = "Nathen", Age = 22, Dogs = new List<Dog> {
        new Dog { Name = "Rover", Age = 2, Color = "brown" }
    }},
    new Person { FirstName = "Amelia", Age = 35, Dogs = new List<Dog> {
        new Dog { Name = "Luna", Age = 4, Color = "white" }
    }},
    new Person { FirstName = "Robert", Age = 44, Dogs = new List<Dog>() }
};
Console.WriteLine("======== 1 =========");
var rNames = people
    .Where(p => p.FirstName.StartsWith("R"))
    .OrderByDescending(p => p.Age)
    .Select(p => p.FirstName);

Console.WriteLine("Persons with names starting with 'R' (Age DESC):");
foreach (var name in rNames)
    Console.WriteLine(name);

Console.WriteLine(" ");
Console.WriteLine("========= 2 ========");
var brownDogs = people
    .SelectMany(p => p.Dogs)
    .Where(d => d.Color == "brown" && d.Age > 3)
    .OrderBy(d => d.Age)
    .Select(d => $"{d.Name} ({d.Age} years)");

Console.WriteLine("\nBrown dogs older than 3 (Age ASC):");
foreach (var dog in brownDogs)
    Console.WriteLine(dog);

Console.WriteLine(" ");
Console.WriteLine("====== 3 =======");
var moreThan2Dogs = people
    .Where(p => p.Dogs.Count > 2)
    .OrderByDescending(p => p.FirstName)
    .Select(p => p.FirstName);

Console.WriteLine("\nPersons with more than 2 dogs (Name DESC):");
foreach (var name in moreThan2Dogs)
    Console.WriteLine(name);

Console.WriteLine(" ");
Console.WriteLine("====== 4 =======");
var freddysDogs = people
    .FirstOrDefault(p => p.FirstName == "Freddy")?
    .Dogs.Where(d => d.Age > 1)
    .Select(d => d.Name);

Console.WriteLine("\nFreddy's dogs older than 1:");
if (freddysDogs != null)
    foreach (var name in freddysDogs)
        Console.WriteLine(name);

Console.WriteLine(" ");
Console.WriteLine("====== 5 =======");
var nathensFirstDog = people
    .FirstOrDefault(p => p.FirstName == "Nathen")?
    .Dogs.FirstOrDefault();

Console.WriteLine("\nNathen's first dog:");
if (nathensFirstDog != null)
    Console.WriteLine(nathensFirstDog.Name);

Console.WriteLine(" ");
Console.WriteLine("====== 6 =======");
var whiteDogs = people
    .Where(p => new[] { "Cristofer", "Freddy", "Erin", "Amelia" }.Contains(p.FirstName))
    .SelectMany(p => p.Dogs)
    .Where(d => d.Color == "white")
    .OrderBy(d => d.Name)
    .Select(d => d.Name);

Console.WriteLine("\nWhite dogs from Cristofer, Freddy, Erin and Amelia:");
foreach (var name in whiteDogs)
    Console.WriteLine(name);
