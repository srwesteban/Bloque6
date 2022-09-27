using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDatos
{
    public class Nombre
    {
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public Nombre()
        {

        }
        public Nombre(string nombre, string primerapellido, string segundoapellido)
        {
            this.nombre = nombre;
            this.primerApellido = primerapellido;
            this.segundoApellido = segundoapellido;
        }
        public void Leer_nombre(string a,string b, string c)
        {
            this.nombre = a;
            this.primerApellido = b;
            this.segundoApellido = c;
        }
        public override string ToString()
        {
            return $"Nombre Completo: {nombre} {primerApellido} {segundoApellido}";
        }

    }
}
