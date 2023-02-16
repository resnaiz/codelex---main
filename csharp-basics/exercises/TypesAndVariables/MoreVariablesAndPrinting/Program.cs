using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Eyes, Teeth, Hair;
            int Age;
            double Height, Weight;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = 74 * 2.54;
            Weight = 180 * 0.453592;
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine($"Let's talk about {Name}.");
            Console.WriteLine($"He's {Height:F2} centimeters tall.");
            Console.WriteLine($"He's {Weight:F2} kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine($"He's got {Eyes} eyes and {Hair} hair.");
            Console.WriteLine($"His teeth are usually {Teeth} depending on the coffee.");

            Console.WriteLine($"If I add {Age}, {Height:F2} centimeters, and {Weight:F2} kilograms, I get {(Age + Height + Weight):F2}.");

            Console.ReadKey();
        }
    }
}