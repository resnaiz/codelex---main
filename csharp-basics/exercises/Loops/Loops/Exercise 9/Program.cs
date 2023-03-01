using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int desiredSum;

            Console.Write("Enter desired sum:");

            while(!int.TryParse(Console.ReadLine(), out desiredSum) || desiredSum < 2 || desiredSum > 12)
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Enter desired sum:");
            }

            int firstRoll;
            int secondRoll;
            int numberSum;

            do
            {
                firstRoll = randomNum.Next(1, 7);
                secondRoll = randomNum.Next(1, 7);
                numberSum = firstRoll + secondRoll;
                Console.WriteLine("{0} and {1} = {2}", firstRoll, secondRoll, numberSum);
            } while (numberSum != desiredSum);
        }
    }
}
