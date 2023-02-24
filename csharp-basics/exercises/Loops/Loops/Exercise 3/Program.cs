using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            int[] numbersRan = new int[20];

            for(int i = 0; i < 20; i++)
            {
                numbersRan[i] = randomNumbers.Next(1, 100);
            }

            Console.WriteLine("Enter position (1-20): ");
            int newPosition = int.Parse(Console.ReadLine());

            if(newPosition < 1 || newPosition > 20)
            {
                Console.WriteLine("Invalid position.");
            }
            else
            {
                int number = numbersRan[newPosition - 1];
                Console.WriteLine($"The number at position {newPosition} is {number}");
            }
        }
    }
}
