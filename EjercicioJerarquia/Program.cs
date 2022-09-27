namespace EjercicioJerarquia
{
    public class Program
    {
        static void Main(string[] args)
        {
            double radio=7;
            double altura = 5;
            double radioInterno = 2;

            Circulo circulo = new Circulo();
            circulo.Leer(radio);
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