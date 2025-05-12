using app.Models;

var printer = new PrintInConsole();

printer.Print("Hello World!");
printer.Print(123);
printer.Print(45.67);

List<string> names = new List<string> { "Viktor", "Bob", "Bobski" };
printer.PrintCollection(names);

int[] numbers = { 1, 2, 3, 4, 5 };
printer.PrintCollection(numbers);