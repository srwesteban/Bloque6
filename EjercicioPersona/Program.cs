namespace EjercicioPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("William", "calle 123", "ing. software", 2022, 3000000);
            Console.WriteLine(student);
            Staff staff = new Staff("Ingenieros", "avenida 123", "UCC", 150000);
            Console.WriteLine(staff);
        }
    }
}