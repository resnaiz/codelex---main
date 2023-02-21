using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine().ToUpper();
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                switch (c)
                {
                    case 'A':
                    case 'B':
                    case 'C':
                        result = result + "2";
                        break;
                    case 'D':
                    case 'E':
                    case 'F':
                        result = result + "3";
                        break;
                    case 'G':
                    case 'H':
                    case 'I':
                        result = result + "4";
                        break;
                    case 'J':
                    case 'K':
                    case 'L':
                        result = result + "5";
                        break;
                    case 'M':
                    case 'N':
                    case 'O':
                        result = result + "6";
                        break;
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        result = result + "7";
                        break;
                    case 'T':
                    case 'U':
                    case 'V':
                        result = result + "8";
                        break;
                    case 'W':
                    case 'Y':
                    case 'X':
                    case 'Z':
                        result = result + "9";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Here is the result for Keyboard sequence: " + result);
        }
    }
}
