using Task4.Entities.Models;

Employee manager = new Manager("Alice", 101, 5000, 1200);
Employee programmer = new Programer("Bob", 102, 30, 160);

manager.DisplayInfo();
programmer.DisplayInfo();