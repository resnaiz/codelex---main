using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

            int score = 0;
            bool gameIsOver = false;

            while (!gameIsOver)
            {
                int newRoll = RollOver();

                if (newRoll == 1)
                {
                    Console.WriteLine("You rolled a 1!");
                    Console.WriteLine("You got 0 points.");
                    gameIsOver = true;
                }
                else
                {
                    Console.WriteLine($"You rolled a {newRoll}");
                    score += newRoll;
                    Console.WriteLine("Roll again?");
                    string newInput = Console.ReadLine();

                    if (newInput == "y" || newInput == "yes")
                    {
                        continue;
                    }     
                    else if (newInput == "n" || newInput == "no")
                    {
                        Console.WriteLine($"You got {score} points.");
                        gameIsOver = true;
                    }
                }
            }
        }

        static int RollOver()
        {
            Random randomNum = new Random();
            return randomNum.Next(1, 7);
        }
    }
}
