namespace EjercicioAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Mamifero");
            Console.WriteLine(animal);

            Mammal mamal = new Mammal("Gato o perro") ;
            Console.WriteLine(mamal);
            Console.WriteLine();

            Cat cat = new Cat("pepe");
            Console.WriteLine(cat);
            cat.greets();
            Console.WriteLine();

            Dog dog = new Dog("Max");
            Console.WriteLine(dog);
            dog.greets();
            Console.WriteLine("\notro perro\n");
            Dog dog2 = new Dog("pancho");
            Console.WriteLine(dog2);
            dog.greets(dog2);
        }
    }
}