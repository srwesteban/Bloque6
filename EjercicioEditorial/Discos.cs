using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorial
{
    public class Discos:Publicacion
    {
        public float duration { get; set; }        
        public Discos(float duracion,string titulo,float precio):base(titulo,precio)
        {
            this.duration = duracion;
            this.titulo = titulo;
            this.precio = precio;
        }

        public void reproduciendo()
        {
            Console.WriteLine("Reproduciendo: La La laLa la lala la");
        }

        public override string ToString()
        {
            return $"Titulo del disco {titulo}, Precio: {precio}, Duracion: {duration}";
        }

    }
}
