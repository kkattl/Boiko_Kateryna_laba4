using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba4
{
    //Створити суперклас Домашня тварина і підкласи Собака, Кішка, Папуга, Птах.
    //За допомогою конструктора встановити ім'я кожної тварини і його характеристики.
    //Вивести на екран голос, який подає домашня тварина
    abstract class AbstrPet
    {
        public abstract string PetSpecies { get; }
        public string Name;
        public abstract int Legs { get; }
        public abstract bool Fur { get; }
        public abstract string Voise { get; }
        public abstract void Infofmation();
    }
}
