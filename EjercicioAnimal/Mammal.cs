using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAnimal
{
    public class Mammal:Animal
    {
        public Mammal(string name):base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Nombre de los mamiferos: {name}";
        }
    }
}
