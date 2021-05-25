using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndExtensionsHomework.PetClasses
{
    public class Dog : Pet
    {
        public Dog(string favouriteFood) : base("Bella", "Dog", 6)
        {
            
        }

        public string FavouriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet has name {this.Name}, is of type {this.Type} and has age {this.Age}");
        }
    }
}
