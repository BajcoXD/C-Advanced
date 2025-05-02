using _01Exercise.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Exercise.Entities
{
    public class PetStore<T> where T : Pet
    {
        private List<T> pets = new List<T>();

        public void AddPet(T pet)
        {
            pets.Add(pet);
        }

        public void PrintPets()
        {
            Console.WriteLine($"\n--- Printing {typeof(T).Name}s in Store ---");
            foreach (var pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            var pet = pets.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (pet != null)
            {
                pets.Remove(pet);
                Console.WriteLine($"\nSuccessfully purchased {pet.Type} named '{pet.Name}'.");
            }
            else
            {
                Console.WriteLine($"\nNo {typeof(T).Name} found with the name '{name}'.");
            }
        }
    }
}
