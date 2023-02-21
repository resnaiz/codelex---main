using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstYear = 1756;
            int secondYear = 1555;
            int thirdYear = 1000;
            int fourthYear = 1001;
            int fifthYear = 2003;

            Console.WriteLine($"Century of the year: {firstYear} - " + centuryGet(firstYear));
            Console.WriteLine($"Century of the year: {secondYear} - " + centuryGet(secondYear));
            Console.WriteLine($"Century of the year: {thirdYear} - " + centuryGet(thirdYear));
            Console.WriteLine($"Century of the year: {fourthYear} - " + centuryGet(fourthYear));
            Console.WriteLine($"Century of the year: {fifthYear} - " + centuryGet(fifthYear));
        }
        public static string centuryGet(int year)
        {
            int num = year % 100 == 0 ? year / 100 : year / 100 + 1;
            if(num > 20)
            {
                return num + "st century";
            }
            else
            {
                return num + "th century";
            }
        }
    }
}
