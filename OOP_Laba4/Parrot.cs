using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba4
{
    internal class Parrot : Bird
    {
        public override string Type => "parrot";
        public Parrot(string name)
        {
            Name = name;
        }
        public override string Voise => "Gosha good";
    }
}
