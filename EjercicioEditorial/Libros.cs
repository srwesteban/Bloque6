using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorial
{
    public class Libros:Publicacion
    {
        public int numberPage { get; set; }
        public int yearPublication {get; set; }

        public Libros(int numberPage,int yearPublication,string titulo, float precio) : base(titulo,precio)
        {
            this.titulo = titulo;
            this.numberPage = numberPage;  
            this.yearPublication = yearPublication;
            this.precio = precio;
        }
        public void print()
        {
            Console.WriteLine("imprimiendo paginas....");
        }
        public override string ToString()
        {
            return $"Titulo: {titulo}, Precio: {precio}, Numero de paginas: {numberPage}, Fecha de publicacion: {yearPublication}";
        }

    }
}
