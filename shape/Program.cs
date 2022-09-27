using System.Globalization;
using System.Xml.Linq;

namespace EjercicioShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circulos:");

            Circulo circuloSinparametros = new Circulo();
            Console.WriteLine(circuloSinparametros);

            Circulo circuloConparametros = new Circulo(2,"azul",false);
            Console.WriteLine(circuloConparametros);
            Console.WriteLine();

            Console.WriteLine("Rectangulos");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);

            Rectangle rectangle2 = new Rectangle(2,4);
            Console.WriteLine(rectangle2);

            Rectangle rectangle3 = new Rectangle(6,8,"azul",false);
            Console.WriteLine(rectangle3);
            Console.WriteLine();

            Console.WriteLine("Cuadrado");
            Square square = new Square();
            Console.WriteLine(square);
            Console.WriteLine();
            Console.WriteLine("Ingrese el color del cuadrado");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el valor en cm de uno de los lados");
            double cm = Convert.ToDouble(Console.ReadLine());            
            Square square2 = new Square(8876,cm,cm,color,true);
            Console.WriteLine(square2);

        }
    }
}