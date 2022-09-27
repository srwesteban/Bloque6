using System.Runtime.CompilerServices;
using System.Xml;

namespace EjercicioDatos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Nombre name = new Nombre();
            name.Leer_nombre("William", "Esteban", "Mora");
            Console.WriteLine(name);
            Console.WriteLine("Datos completos");
            Direccion direccion = new Direccion("William", "Esteban", "Mora","A # 123","Nariño",520002);
            Console.WriteLine(direccion);

            Console.WriteLine("\nNuevos datos\n");

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su primer apellido: ");
            string primerA = Console.ReadLine();
            Console.Write("Ingrese su segundo apellido: ");
            string segundoA = Console.ReadLine();
            direccion.nuevo_nombre(nombre, primerA, segundoA);

            Console.WriteLine("\nIngrese su direccion\n");
            Console.Write("Calle:");
            string calle = Console.ReadLine();
            Console.Write("Provincia:");
            string provincia = Console.ReadLine();
            Console.Write("Codigo postal:"); 
            int codigo = int.Parse(Console.ReadLine());
            direccion.nueva_dirreccion(calle,provincia,codigo);
            Console.WriteLine();
            Console.WriteLine(direccion);


        }
    }
}