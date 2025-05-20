using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entities.Models
{
    public static class ListHelper
    {
        // Generic method to print any list
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine("Printing...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }

        // Method to print specific properties of Car objects
        public static void PrintCarModels(this List<Car> list)
        {
            Console.WriteLine("Printing Car Models...");
            Console.WriteLine("------------------------------");
            foreach (Car car in list)
            {
                Console.WriteLine(car.Model);
            }
            Console.WriteLine("------------------------------");
        }
    }
}
