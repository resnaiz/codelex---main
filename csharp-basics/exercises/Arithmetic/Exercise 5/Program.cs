using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberGuess = random.Next(0, 100);
            int guess;

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            guess = Convert.ToInt32(Console.ReadLine());
            while (guess != numberGuess)
            {
                if (guess < numberGuess)
                {
                    Console.WriteLine($"Sorry, you are too low. I was thinking of {numberGuess}.");
                }
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!  What are the odds?!?");
            Console.ReadLine();
        }
    }
}
