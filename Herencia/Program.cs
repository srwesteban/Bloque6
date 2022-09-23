namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(1.0,"rojo");
            Console.WriteLine(circulo);
            Cilindro cilindro = new Cilindro(2,"azul",2);
            Console.WriteLine(cilindro);
        }
    }
}