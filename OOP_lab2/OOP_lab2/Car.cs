using System;
using System.Threading;

namespace OOP_lab2
{
    public class Car
    {
        private Engine engine;
        private string make;
        private string model;

        public Car(string make, string model, Engine engine)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
        }

        public Car(string make, string model, Engine engine, double engineCapacity, double fuelLevel):
            this(make, model, new Engine(engineCapacity, fuelLevel))
        {

        }

        public void Drive(double distance)
        {
            Console.WriteLine("Now driving...");
            Thread.Sleep((int)(100 * distance));
            engine.Work(distance);
            Console.WriteLine("Target reached!");
        }

        public void Refuel(double liters)
        {
            engine.
        }
    }
}