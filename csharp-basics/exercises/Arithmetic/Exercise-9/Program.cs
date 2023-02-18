using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in pounds or kilograms:");
            double personWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in inches or centimeters:");
            double personHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter '1' if you entered data in pounds/inches but '2' if - in kilograms and centimeters");
            int units = int.Parse(Console.ReadLine());

            double bmi;
            if (units == 1)
            {
                bmi = (personWeight * 703) / (personHeight * personHeight);
            }
            else
            {
                bmi = personWeight / Math.Pow(personHeight / 100, 2);
            }
            Console.WriteLine($"Your BMI is - {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("You're underweight");
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                Console.WriteLine("Your weight is optimal");
            }
            else
            {
                Console.WriteLine("You're overweight");
            }
        }
    }
}