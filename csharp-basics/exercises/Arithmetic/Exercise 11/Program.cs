using System;

public class Program
{
    public static string Moran(int num)
    {
        int rem = 0;
        int sum = 0;
        int n = num;

        while (num > 0)
        {
            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
        }
        bool isMoran = false;
        if (n % sum == 0)
        {
            int quotient = n / sum;
            for (int i = 2; i <= Math.Sqrt(quotient); i++)
            {
                if (quotient % i == 0)
                {
                    isMoran = false;
                    break;
                }
                else
                {
                    isMoran = true;
                }
            }
        }
        if (isMoran)
        {
            return "M";
        }
        else if (n % sum == 0)
        {
            return "H";
        }
        else
        {
            return "Neither";
        }
    }
    public static void Main()
    {
        Console.WriteLine(Moran(132));
        Console.WriteLine(Moran(133));
        Console.WriteLine(Moran(134));
        Console.WriteLine(Moran(135));
        Console.WriteLine(Moran(88));
    }
}
