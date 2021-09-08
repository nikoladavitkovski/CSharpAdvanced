using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndExtensionsHomework.PetClasses
{
    public class Cat : Pet
    {
        public Cat(bool lazy, int livesleft) : base("Catty", "Cat", 5)
        {
            Lazy = lazy;
            LivesLeft = livesleft;
        }
        public bool Lazy { get; set; }

        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet has name {this.Name}, is of type {this.Type} and has age {this.Age}");
        }
    }
}
