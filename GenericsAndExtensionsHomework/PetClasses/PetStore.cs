using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsAndExtensionsHomework.PetClasses
{
    public class PetStore<T>
    {
        public List<Dog> Dogs { get; set; } = new List<Dog>() { };

        public List<Cat> Cats { get; set; } = new List<Cat>() {};

        public List<Fish> Fish { get; set; } = new List<Fish>() { };

        public void PrintPets<Dog>(string Type)
        {
            if (Type == "Dog") {
                foreach (var dog in Dogs)
                {
                    Console.WriteLine("Dog type: "+dog.Type+" Dog's favourite food " + dog.FavouriteFood);
                }
            }
            if(Type == "Cat")
            {
                foreach (var cat in Cats)
                {
                    Console.WriteLine("Cat type: "+cat.Type+" Is cat lazy: " +cat.Lazy + " and has lives left: " + cat.LivesLeft);
                }
            }
            if(Type == "Fish")
            {
                foreach (var fish in Fish)
                {
                    Console.WriteLine("Fish type: "+fish.Type+" Color: " + fish.Color + " Size: " + fish.Size);
                }
            }
        }
        public void BuyPet(string name)
        {
            if (name != "Bella")
            {
                Console.WriteLine("There is no pet by that name");
            }
            Dogs.FirstOrDefault(dog => dog.Name == "Bella");
            Console.WriteLine($"Dogs.Remove({name}" == "Bella");
            Console.WriteLine("The pet is successfully removed from the list");
            
        }
        public void Store()
        {
            Dogs = new List<Dog>()
            {
                new Dog("Meat"),
                new Dog("Bone")
            };
            Cats = new List<Cat>()
            {
                new Cat(true,9),
                new Cat(false,9)
            };
            Fish = new List<Fish>()
            {
                new Fish("yellow",0.3),
                new Fish("green",0.4)
            };
        }
        public void BuyPet(List<Dog> Dogs, List<Cat> Cats)
        {
            Console.WriteLine(Dogs[0]);
            Console.WriteLine(Cats[0]);
        }
    }
}
