using System;
using GenericsAndExtensionsHomework.PetClasses;

namespace GenericsAndExtensionsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> petStore = new PetStore<Dog>();
            petStore.PrintPets<Dog>("Dog");
            petStore.PrintPets<Cat>("Cat");
            petStore.PrintPets<Fish>("Fish");
            Console.ReadLine();
        }
    }
}
