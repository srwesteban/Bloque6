using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorial
{
    public class Publicacion
    {
        public string titulo { get; set; }
        public float precio { get; set; }

        public Publicacion(string titulo, float precio)
        {
            this.titulo = titulo;
            this.precio = precio;   
        }
        public void publicando()
        {
            Console.WriteLine("publicando...");
        }
        public override string ToString()
        {
            return "publicacion";
        }



    }
}
