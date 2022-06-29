using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba4
{
    internal class Dog : AbstrPet
    {
        public override string PetSpecies => "dog";
        public Dog(string name)
        {
            Name = name;
        }
        public override int Legs => 4;
        public override string Voise => "gav, gav";
        public override bool Fur => true;

        public override void Infofmation()
        {
            Console.WriteLine($"=====Information=====");
            Console.WriteLine($"Species of pet: {PetSpecies }");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"It has fur: {Fur}");
            Console.WriteLine($"Voise: {Voise}");
            Console.WriteLine("\n");
        }
   
    }
}
