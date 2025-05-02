using _01Exercise.Entities.Models;
using _01Exercise.Entities;

var dogStore = new PetStore<Dog>();
var catStore = new PetStore<Cat>();
var fishStore = new PetStore<Fish>();

//pets
dogStore.AddPet(new Dog("Rex", 5, true, "Bones"));
dogStore.AddPet(new Dog("Buddy", 3, true, "Chicken"));

catStore.AddPet(new Cat("Whiskers", 2, true, 9));
catStore.AddPet(new Cat("Luna", 4, false, 8));

fishStore.AddPet(new Fish("Goldie", 1, "Gold", "Small"));
fishStore.AddPet(new Fish("Bubbles", 2, "Blue", "Medium"));

// Buy a dog and a cat
dogStore.BuyPet("Rex");
catStore.BuyPet("Luna");

// Print remaining pets
dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();