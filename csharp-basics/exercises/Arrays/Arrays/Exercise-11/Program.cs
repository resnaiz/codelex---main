using System;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Nemo("I am finding Nemo !"));
            Console.WriteLine(Nemo("Nemo is me"));
            Console.WriteLine(Nemo("I Nemo am"));
            Console.WriteLine(Nemo("Hi, nemo!"));
            Console.WriteLine(Nemo("Oopsies, nothing!"));
        }

        static string Nemo(string text)
        {
            string[] word = text.Split(' ');

            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == "Nemo")
                {
                    return $"I found Nemo at {i + 1}!";
                }
            }

            return "I can't find Nemo :(";
        }
    }
}
