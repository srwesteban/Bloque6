namespace EjercicioJerarquia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double radio=3;
            double altura = 5;
            double radioInterno = 7;

            Circulo circulo = new Circulo();
            circulo.Leer(radio);

            circulo.Area();

            Console.WriteLine(circulo);

            Cilindro cilindro = new Cilindro();
            cilindro.Leer(radio,altura);
            Console.WriteLine(cilindro);

            CilindroHueco cilindroHueco = new CilindroHueco();
            cilindroHueco.Leer(radio,altura,radioInterno);
            Console.WriteLine(cilindroHueco);
        }
    }
}