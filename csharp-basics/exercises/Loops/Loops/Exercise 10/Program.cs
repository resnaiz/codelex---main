using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Max? ");
            int otherInput = int.Parse(Console.ReadLine());

            int squareSize = otherInput - input + 1;

            for(int row = 0; row < squareSize; row++)
            {
                for(int col = 0; col < squareSize; col++)
                {
                    int value = input + ((row + col) % squareSize);
                    Console.Write(value);
                }

                Console.WriteLine();
            }
        }
    }
}
