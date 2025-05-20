using System;
using System.Collections.Generic;
using System.Linq;
using app.Entities.Models; 
using app.Entities;       


List<Car> cars = CarsData.Cars;  // Access the static list directly

// 1. Filter all cars that have origin from Europe and print them
var europeanCars = cars.Where(c => c.Origin == "Europe").ToList();
Console.WriteLine("European Cars:");
europeanCars.PrintCarModels();  // Use the correct extension method

// 2. Filter all cars that have more than 6 Cylinders (excluding 6)
var moreThan6Cylinders = cars.Where(c => c.Cylinders > 6);

// Filter all cars that have exactly 4 Cylinders and have HorsePower more than 110.0
var fourCylindersHighHP = cars.Where(c => c.Cylinders == 4 && c.HorsePower > 110.0);

// Join them in one result and print them
var combinedCars = moreThan6Cylinders.Concat(fourCylindersHighHP).ToList();
Console.WriteLine("Combined Cars (Cylinders > 6 or 4 Cylinders with HP > 110):");
combinedCars.PrintCarModels();

// 3. Count all cars based on their Origin and print the result
var countByOrigin = cars
    .GroupBy(c => c.Origin)
    .Select(g => $"{g.Key} {g.Count()} models")
    .ToList();
Console.WriteLine("Car Counts by Origin:");
countByOrigin.PrintSimple();

// 4. Filter all cars that have more than 200 HorsePower and find min, max, and average MPG
var highHpCars = cars.Where(c => c.HorsePower > 200).ToList();
if (highHpCars.Any())
{
    var minMPG = highHpCars.Min(c => c.MilesPerGalon);
    var maxMPG = highHpCars.Max(c => c.MilesPerGalon);
    var avgMPG = highHpCars.Average(c => c.MilesPerGalon);

    Console.WriteLine("Cars with HP > 200 - MPG Stats:");
    Console.WriteLine($"Lowest MPG: {minMPG}");
    Console.WriteLine($"Highest MPG: {maxMPG}");
    Console.WriteLine($"Average MPG: {avgMPG:F2}");
}
else
{
    Console.WriteLine("No cars with horsepower > 200.");
}

// 5. Find the top 3 fastest accelerating cars
var top3Fastest = cars.OrderBy(c => c.AccelerationTime).Take(3).ToList();
Console.WriteLine("Top 3 Fastest Accelerating Cars:");
top3Fastest.PrintCarModels();

// 6. Calculate the total weight of cars with more than 6 cylinders
var totalWeight = cars.Where(c => c.Cylinders > 6).Sum(c => c.Weight);
Console.WriteLine($"Total Weight of Cars with >6 Cylinders: {totalWeight} lbs");

// 7. Find the average MilesPerGalon for cars with even number of cylinders
var evenCylindersCars = cars.Where(c => c.Cylinders % 2 == 0).ToList();
if (evenCylindersCars.Any())
{
    var avgMPGEvenCylinders = evenCylindersCars.Average(c => c.MilesPerGalon);
    Console.WriteLine($"Average MPG (Even Cylinders): {avgMPGEvenCylinders:F2}");
}
else
{
    Console.WriteLine("No cars with even number of cylinders.");
}
