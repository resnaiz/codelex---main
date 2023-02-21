using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = Console.ReadLine();
            long num;

            if (long.TryParse(input, out num)) 
            {
                if (num < 0) 
                {
                    num *= -1;
                }
                if (num >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (num >= 10) 
                    {
                        digits = 2;
                    } 
                    if (num >= 100) 
                    {
                        digits = 3;
                    } 
                    if (num >= 1000) 
                    {
                        digits = 4;
                    } 
                    if (num >= 10000) 
                    {
                        digits = 5;
                    } 
                    if (num >= 100000) 
                    {
                        digits = 6;
                    } 
                    if (num >= 1000000) 
                    {
                        digits = 7;
                    } 
                    if (num >= 10000000) 
                    {
                        digits = 8;
                    } 
                    if (num >= 100000000) 
                    {
                        digits = 9;
                    } 
                    if (num >= 1000000000) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
        }
    }
}
