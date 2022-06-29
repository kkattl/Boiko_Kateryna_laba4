using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba4
{
    abstract class Bird : AbstrPet
    {
        public override string PetSpecies => "bird";
        public override int Legs => 2;
        public override bool Fur => false;
        abstract public string Type { get; }
        public override void Infofmation()
        {
            Console.WriteLine($"=====Information=====");
            Console.WriteLine($"Species of pet: {PetSpecies} ( {Type} )");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"It has fur: {Fur}");
            Console.WriteLine($"Voise: {Voise}");
            Console.WriteLine("\n");
        }
    }
}
