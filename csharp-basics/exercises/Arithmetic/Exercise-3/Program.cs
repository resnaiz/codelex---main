using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int product = 1;

            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}

