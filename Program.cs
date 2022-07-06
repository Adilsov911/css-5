using System;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();

            cat1.name = "Garfield";
            cat1.age = 2;
            cat1.color = "Orange";
            Console.WriteLine(cat1.GetDetails());

            Dogs dog1 = new Dogs();

            dog1.name = "Rotwiller";
            dog1.age = 1;
            dog1.color = "Black";
            Console.WriteLine(dog1.GetDetails());

        }
    }
}
