using System;

namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Odometer newOdometer = new Odometer();

            for(int i = 0; i < 70; i++)
            {
                newOdometer.fuelGauge.RefuelLimit();
            }

            while(newOdometer.fuelGauge.GetFuelAmount() > 0)
            {
                newOdometer.IncreaseMileage();
                Console.WriteLine("Current mileage is - " + newOdometer.GetMileage() + " km.");
                Console.WriteLine("Current fuel level: " + newOdometer.fuelGauge.GetFuelAmount() + " L");
            }

            Console.WriteLine("Out of fuel.");
        }
    }
}
