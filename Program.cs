using System;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw car = new Bmw();

            car.model = "BMW 525";
            car.price = 14000;
            car.speed = 260;
            car.color = "Black";
            Console.WriteLine(car.GetDetails());

            Mercedes car1 = new Mercedes();

            car1.model = "Mercedes E Class";
            car1.price = 75000;
            car1.speed = 260;
            car1.color = "Black";
            Console.WriteLine(car1.GetDetails());

        }
    }
}
