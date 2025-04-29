using ConsoleApp1.Models;

Shape circle = new Circle(5);
Shape triangle = new Triangle(3, 4, 5);

Console.WriteLine("Circle:");
Console.WriteLine($"Area: {circle.CalculateArea():F2}");
Console.WriteLine($"Perimeter: {circle.CalculatePerimeter():F2}");

Console.WriteLine("\nTriangle:");
Console.WriteLine($"Area: {triangle.CalculateArea():F2}");
Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter():F2}");