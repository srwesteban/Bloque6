using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDatos
{
    public class Direccion:Nombre
    {
        public string calle { get; set; }
        public string provincia { get; set; }
        public int codigoPostal { get; set; }

        public Direccion(string nombre,string primerA,string segundoA, string calle, string provincia , int codigoPoastal)
            :base(nombre,primerA,segundoA)
        {
            this.nombre = nombre;
            this.primerApellido= primerA;
            this.segundoApellido= segundoA;
         
            this.calle = calle;
            this.provincia = provincia;
            this.codigoPostal = codigoPoastal;           

        }
        public void nueva_dirreccion(string a,string b,int c)
        {
            this.calle = a;
            this.provincia = b;
            this.codigoPostal = c;
        }
        public void nuevo_nombre(string a,string b,string c)
        {
            this.nombre = a;
            this.primerApellido = b;
            this.segundoApellido = c;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre} {primerApellido} {segundoApellido} calle: {calle} proviencia: {provincia}, codigo: {codigoPostal}";
        }
    }
}
