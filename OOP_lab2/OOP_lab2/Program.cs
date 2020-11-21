using System;

namespace OOP_lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            new Engine(2.0, 30);
            new Engine(2.4, 72, 72);

            var car = new Car("Lada", "Samara", new Engine(1.4, 30));

            car.Drive(200);
        }
    }
}
