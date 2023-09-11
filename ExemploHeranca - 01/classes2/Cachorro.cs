using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca___01.classes2
{
    internal class Cachorro:Mamifero
    {
        public double Peso { get; set; }

        public override void Barulho()
        {
            Console.WriteLine("Auauauau!");
        }
    }
}
