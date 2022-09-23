using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    public class Staff : Persona
    {
        public string school { get; set; }
        public double pay { get; set; }

        public Staff(string name,string address, string schoool, double pay):base(name,address)
        {
            this.name = name;
            this.address = address;
            this.school = schoool;
            this.pay = pay;

        }
        public override string ToString()
        {
            return $"Staff: {name} direccion: {address} escuela: {school} pago: {pay} ";
        }
    }
}
