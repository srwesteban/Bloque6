using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAnimal
{
    public class Cat:Mammal
    {
        public Cat(string name): base(name)
        {
            this.name = name;
        }
        public void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            return $"Nombre del gato: {name}";
        }
    }
}
