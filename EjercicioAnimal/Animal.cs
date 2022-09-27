using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAnimal
{
    public class Animal
    {
        public string name;
        
        public Animal(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Tipo de animal: {name}";
        }
    }
}
