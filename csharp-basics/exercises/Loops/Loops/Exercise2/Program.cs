using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int res = 1;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            for (int i = 0; i < n; i++)
            {
                res *= n;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
