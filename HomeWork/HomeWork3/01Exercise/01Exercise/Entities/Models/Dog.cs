using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Exercise.Entities.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, int age, bool goodBoy, string favoriteFood)
            : base(name, "Dog", age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog - Name: {Name}, Age: {Age}, GoodBoy: {GoodBoy}, Favorite Food: {FavoriteFood}");
        }
    }
}
