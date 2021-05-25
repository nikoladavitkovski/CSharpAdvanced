using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsAndExtensionsHomework.PetClasses
{
    public class PetStore<T>
    {
        public List<Dog> Dogs { get; set; } = new List<Dog>() { };

        public List<Cat> Cats { get; set; } = new List<Cat>() { };

        public List<Fish> Fish { get; set; } = new List<Fish>() { };

        public void PrintPets<Dog>(string type)
        {
            if(type == "Dog")
            {
                Console.WriteLine("The pet is of type dog");
            } if(type == "Cat")
            {
                Console.WriteLine("The pet is of type cat");
            } if(type == "Fish")
            {
                Console.WriteLine("The pet is of type fish");
            }
        }
        public void BuyPet(string name)
        {
            Console.WriteLine($"The first pet by the name of Bella is {Dogs[0]}");
            Console.WriteLine(Dogs.Remove(Dogs[0]));
            Console.WriteLine("The pet is successfully removed");
            if(name != "Dogs[0]")
            {
                Console.WriteLine("There is no pet by that name");
            }
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
            PrintPets<Dog>("Dog");
            PrintPets<Cat>("Cat");
            PrintPets<Fish>("Fish");
        }
        public void BuyPet(List<Dog> Dogs, List<Cat> Cats)
        {
            Console.WriteLine(Dogs[0]);
            Console.WriteLine(Cats[0]);
        }
    }
}
