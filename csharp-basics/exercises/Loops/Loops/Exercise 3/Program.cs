using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            int[] numbersRan = new int[20];

            for (int i = 0; i < 20; i++)
            {
                numbersRan[i] = randomNumbers.Next(1, 100);
            }

            bool found = false;

            while(!found)
            {
                Console.WriteLine("Enter number: ");
                int searchNumber = int.Parse(Console.ReadLine());

                int position = Array.IndexOf(numbersRan, searchNumber);

                if (position == -1)
                {
                    Console.WriteLine($"The number {searchNumber} is not in any position.");
                }
                else
                {
                    Console.WriteLine($"The number {searchNumber} is at position {position}");
                    found = true;
                }
            }
        }
    }
}
