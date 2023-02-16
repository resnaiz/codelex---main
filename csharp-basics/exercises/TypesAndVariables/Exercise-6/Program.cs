using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;

            Console.WriteLine("Enter a number:");

            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                m = n % 10;
                sum += m;
                n /= 10;
            }

            Console.WriteLine("Sum is = " + sum);
        }
    }
}
