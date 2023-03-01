using System;
using System.Linq;

public class Program
{
    public static string Moran(int num)
    {
        int sum = num.ToString().Sum(digit => digit - '0');

        if (num % sum == 0)
        {
            bool isMoran = true;
            int txt = num / sum;
            for (int i = 2; i <= txt / 2; i++)
            {
                if (txt % i == 0)
                {
                    isMoran = false;
                    break;
                }
            }
            if (isMoran && txt > 1)
            {
                return "M";
            }
            else
            {
                return "H";
            }
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
