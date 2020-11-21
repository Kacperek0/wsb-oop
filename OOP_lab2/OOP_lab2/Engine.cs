using System;
namespace OOP_lab2
{
    public class Engine
    {
        private double engineCapacity;
        private double fuelLevel;
        public readonly double FuelCapacity;

        private static double defaultFuelCapality;

        static Engine()
        {
            defaultFuelCapality = 60;
        }

        public Engine(double engineCapacity, double fuelLevel)
        {
            this.engineCapacity = engineCapacity;
            this.fuelLevel = fuelLevel;
            this.FuelCapacity = defaultFuelCapality;
        }

        public void Work(double distance)
        {
            var consumption = engineCapacity * 4/100;
            this.fuelLevel -= consumption * distance;
        }

        public void Refuel(double liters)
        {
            if (this.fuelLevel + liters > FuelCapacity)
                throw new Exception();
            Math.Min(this.fuelLevel + liters, FuelCapacity);
        }

        public Engine(double engineCapacity, double fuelLevel, double fuelCapacity):
            this(engineCapacity, fuelLevel) //inicjalizuje konstruktor z dwoma argumentami
        {
            this.FuelCapacity = fuelCapacity;
        }

        public static double ConvertToImperial(double ConsumptionMetric)
        {
            return 1/ConsumptionMetric * 100 * 0.621371192 / 0.264172052;
        }

        public static double ConvertToMetric(double ConsumptionImperial)
        {
            return ConsumptionImperial * 100 * 3.78541 / 62.1371;
        }
    }
}
