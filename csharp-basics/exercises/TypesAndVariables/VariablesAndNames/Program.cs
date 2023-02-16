using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsStop, carsDriven;
            double seatsInCar, carpoolCapacity, averagePassengersPerCar;

            cars = 100;
            seatsInCar = 4.0; 
            drivers = 28;
            passengers = 90; 
            carsStop = cars - drivers;
            carsDriven = cars - carsStop; 
            carpoolCapacity = carsDriven * seatsInCar;
            averagePassengersPerCar = passengers / carsDriven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsStop + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}