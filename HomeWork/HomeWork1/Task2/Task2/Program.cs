using Task2.Entities.Models;

Shape rectangle = new Rectangle(5, 4);
Shape circle = new Circle(3);


Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
