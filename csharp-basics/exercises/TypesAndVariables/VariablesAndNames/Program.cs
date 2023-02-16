using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsStop, carsDriven;
            double seatsInCar, carpoolCapacity, averagePassengersPerCar;

            cars = 100; //cars
            seatsInCar = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            carsStop = cars - drivers;// free cars
            carsDriven = cars - carsStop; // cars driven at the moment
            carpoolCapacity = carsDriven * seatsInCar;// carpool capacity
            averagePassengersPerCar = passengers / carsDriven;// average passengers per car

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