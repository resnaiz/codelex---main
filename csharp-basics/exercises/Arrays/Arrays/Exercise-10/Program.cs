using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] firstResult = CountPosSumNeg(firstNumbers);
            Console.WriteLine($"Result: [" + string.Join(",", firstResult) + "]");

            int[] secondNumbers = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] secondResult = CountPosSumNeg(secondNumbers);
            Console.WriteLine($"Result: [" + string.Join(",", secondResult) + "]");

            int[] thirdNumbers = { };
            int[] thirdResult = CountPosSumNeg(thirdNumbers);
            Console.WriteLine($"Result: [" + string.Join(",", thirdResult) + "]");

            static int[] CountPosSumNeg(int[] numbers)
            {
                if (numbers.Length == 0)
                {
                    return new int[] { };
                }

                int posCount = 0;
                int sumOfNeg = 0;

                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        posCount++;
                    }
                    else if (number < 0)
                    {
                        sumOfNeg += number;
                    }
                }

                return new int[] { posCount, sumOfNeg };
            }
        }
    }
}

