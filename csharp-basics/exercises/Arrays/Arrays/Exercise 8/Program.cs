using System;
using System.Globalization;
using System.Linq;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;

            while (playGame)
            {
                string[] listOfWords = { "leviathan", "monster", "mammoth", "behemoth", "colossus" };
                string oneWord = listOfWords[new Random().Next(listOfWords.Length)];
                string newGuess = "";
                string newMiss = "";
                int tries = 6;

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Word:\t");
                    foreach (char c in oneWord)
                    {
                        if (newGuess.Contains(c))
                        {
                            Console.Write(c);
                        }
                        else
                        {
                            Console.Write("_ ");
                        }
                    }

                    Console.WriteLine("\nMisses:\t{0}", newMiss);

                    Console.Write("Guess:\t");
                    char guess = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (oneWord.Contains(guess))
                    {
                        newGuess += guess;
                    }
                    else
                    {
                        newMiss += guess;
                        tries--;
                    }

                    if (tries == 0)
                    {
                        Console.WriteLine("You have run out of attempts. Word: '{0}'.", oneWord);
                        break;
                    }

                    if (oneWord.All(c => newGuess.Contains(c)))
                    {
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine();
                        Console.WriteLine("Word:\t{0}", oneWord.ToLower());
                        Console.WriteLine("Misses:\t{0}", newMiss);
                        Console.WriteLine("YOU GOT IT!");
                        break;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("\nPlay 'again' or 'quit'?");
                string input = Console.ReadLine();

                while (input != "again" && input != "quit")
                {
                    Console.WriteLine("Invalid input.");
                    input = Console.ReadLine();
                }

                if (input == "again")
                {
                    continue;
                }
                else if (input == "quit")
                {
                    return;
                }
            }
        }
    }
}
