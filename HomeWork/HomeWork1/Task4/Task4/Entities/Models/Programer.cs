using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Entities.Models
{
    public class Programer : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Programer(string name, int id, double hourlyRate, int hoursWorked)
            : base(name, id)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}, ID: {Id}, Salary: {CalculateSalary():C}");
        }
    }
}
