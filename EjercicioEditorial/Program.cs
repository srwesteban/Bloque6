namespace EjercicioEditorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Publicar Disco\n");
            Console.WriteLine("ingrese el titulo del disco");
            string tituloD = Console.ReadLine();
            Console.WriteLine("ingrese el precio");
            float precioD = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la duracion del disco");
            float duration = float.Parse(Console.ReadLine());
            Discos disco = new Discos(duration, tituloD, precioD);
            Console.WriteLine();
            disco.reproduciendo();
            Console.WriteLine();
            Console.WriteLine(disco);
            disco.publicando();


            Console.WriteLine("\nPublicar un libro\n");
            Console.WriteLine("ingrese el titulo del libro");
            string tituloL = Console.ReadLine();
            Console.WriteLine("ingrese el precio");
            float precioL = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de paginas");
            int numberPage = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de publicacion");
            int yearPublication = int.Parse(Console.ReadLine());
            Libros libro = new Libros(numberPage,yearPublication,tituloL, precioL);
            Console.WriteLine();
            libro.print();
            Console.WriteLine();
            Console.WriteLine(libro);
            libro.publicando();


        }
    }
}