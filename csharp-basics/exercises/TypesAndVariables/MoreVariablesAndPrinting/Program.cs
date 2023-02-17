using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName, eyesColor, teethColor, hairColor;
            int personAge;
            double personHeight, personWeight;

            personName = "Zed A. Shaw";
            personAge = 35;
            personHeight = 74 * 2.54;
            personWeight = 180 * 0.453592;
            eyesColor = "Blue";
            teethColor = "White";
            hairColor = "Brown";

            Console.WriteLine($"Let's talk about {personName}.");
            Console.WriteLine($"He's {personHeight:F2} centimeters tall.");
            Console.WriteLine($"He's {personWeight:F2} kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyesColor} eyes and {hairColor} hair.");
            Console.WriteLine($"His teeth are usually {teethColor} depending on the coffee.");

            Console.WriteLine($"If I add {personAge}, {personHeight:F2} centimeters, and {personWeight:F2} kilograms, I get {(personAge + personHeight + personWeight):F2}.");

            Console.ReadKey();
        }
    }
}