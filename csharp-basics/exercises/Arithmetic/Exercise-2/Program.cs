using System;

namespace Exercise_2
{
    internal class CheckOddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine("bye!");
        }
    }
}
