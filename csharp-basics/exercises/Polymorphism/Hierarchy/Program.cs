using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Console.WriteLine("Enter animal: ");
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] animalInfo = input.Split();
                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2], CultureInfo.InvariantCulture);

                Animal animal;

                switch (animalType)
                {
                    case "Mouse":
                        var livingRegion = Console.ReadLine();
                        animal = new Mouse(animalType, animalName, animalWeight, 0, livingRegion);
                        break;
                    default:
                        animal = new Mouse(animalType, animalName, animalWeight, 0, "");
                        break;
                }

                Console.WriteLine("Enter food quantity: ");
                string[] foodInfo = Console.ReadLine().Split();
                Food food;

                switch (foodInfo[0])
                {
                    case "Vegetable":
                        food = new Vegetable(int.Parse(foodInfo[1]));
                        break;
                    case "Meat":
                        food = new Meat(int.Parse(foodInfo[1]));
                        break;
                    default:
                        food = new Vegetable(1);
                        break;
                }

                animal.Eat(food);
                animal.MakeSound();
                animals.Add(animal);

                //animal..MakeSound();
                //animal.Eat(food);
                //animals.Add(animal);

                Console.WriteLine("Enter Animal: ");    
                input = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                string animalType = animal.GetType().Name;
                string animalName = animal.AnimalName;
                double animalWeight = animal.AnimalWeight;
                //string animalLivingRegion = animal.livingRegion;
                int foodEaten = animal.FoodEaten;

            }
        }
    }
}