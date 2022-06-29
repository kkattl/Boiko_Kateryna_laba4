using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Створити суперклас Домашня тварина і підкласи Собака, Кішка, Папуга, Птах.
//За допомогою конструктора встановити ім'я кожної тварини і його характеристики.
//Вивести на екран голос, який подає домашня тварина


namespace OOP_Laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add dog name:");
            string name1 = Console.ReadLine();
            var dog = new Dog(name1);
            dog.Infofmation();
            Console.WriteLine("Add cat name:");
            string name2 = Console.ReadLine();
            var cat = new Cat(name2);
            cat.Infofmation();
            Console.WriteLine("Add parrot name:");
            string name3 = Console.ReadLine();
            var parrot = new Parrot(name3);
            parrot.Infofmation();
            Console.ReadKey();
        }
        
    }
}
