using System;

namespace exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int startNum = 1;
            const int endNum = 110;
            const int numsPerLine = 11;

            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("CozaLoza ");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else
                {
                    Console.Write(i + " ");
                }
                if (i % numsPerLine == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
