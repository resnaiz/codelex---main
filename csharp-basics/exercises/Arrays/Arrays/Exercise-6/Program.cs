using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArray1 = new int[10];
            int[] newArray2 = new int[10];
            Random num = new Random();

            for(int i = 0; i < 10; i++)
            {
                newArray1[i] = num.Next(1, 100);
            }

            Array.Copy(newArray1, newArray2, 10);
            newArray1[9] = -7;
            Console.WriteLine("Array 1:");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(newArray1[i] + " ");
            }

            Console.WriteLine("\nArray 2:");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(newArray2[i] + " ");
            }
        }
    }
}
