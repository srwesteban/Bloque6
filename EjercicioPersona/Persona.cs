using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    public class Persona
    {

        public string name { get; set; }
        public string address { get; set; }

        public Persona(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public override string ToString()
        {
            return $"nombre {name} direccion {address}";
        }


    }
}
