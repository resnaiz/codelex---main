using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max value? ");
            int newInteger = int.Parse(Console.ReadLine());

            for(int i = 1; i <= newInteger; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz");
                }
                else
                {
                    Console.Write($" {i}");
                }

                if(i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
