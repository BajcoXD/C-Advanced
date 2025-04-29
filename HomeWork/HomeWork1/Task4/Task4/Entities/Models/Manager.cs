using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Entities.Models
{
    public class Manager : Employee
    {
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }

        public Manager(string name, int id, double baseSalary, double bonus)
            : base(name, id)
        {
            BaseSalary = baseSalary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, ID: {Id}, Salary: {CalculateSalary():C}");
        }
    }
}
