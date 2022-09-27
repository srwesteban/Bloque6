using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAnimal
{
    public class Dog:Mammal
    {
        public Dog(string name):base(name)
        {
            this.name = name;
        }
        public void greets()
        {
            Console.WriteLine("Woof");
        }
        public void greets(Dog dog)
        {
            Console.WriteLine("Woooof");
        }
        public override string ToString()
        {
            return $"Nombre del perro: {name}";
        }
    }
}
