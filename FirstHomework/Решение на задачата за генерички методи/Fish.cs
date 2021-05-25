using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndExtensionsHomework.PetClasses
{
    public class Fish : Pet
    {
        public Fish(string color, double size) : base("Betty", "Fish", 10)
        {

        }
        public string Color { get; set; }

        public double Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet has name {this.Name}, is of type {this.Type} and has age {this.Age}");
        }
    }
}
