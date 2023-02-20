using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");

            string input = Console.ReadLine();

            int count = 0;

            foreach (char c in input)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }

            Console.WriteLine("Uppercase letters: " + count);
        }
    }
}
