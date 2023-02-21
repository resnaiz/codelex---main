using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if (numberOne == 15 || numberTwo == 15 || numberOne + numberTwo == 15 || Math.Abs(numberOne - numberTwo) == 15)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}