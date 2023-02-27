using System;

namespace Exercise8
{
    internal class Program
    {
        const int FigureSize = 3;

        static void Main(string[] args)
        {
            for(int i = 0; i < FigureSize; i++)
            {
                for(int r = 0; r < (FigureSize - i - 1) * 4; r++)
                {
                    Console.Write("/");
                }

                for(int r = 0; r < i * 8; r++)
                {
                    Console.Write("*");
                }

                for(int r = 0; r < (FigureSize - i - 1) * 4; r++)
                {
                    Console.Write("\\");
                }

                Console.WriteLine();
            }
        }
    }
}
