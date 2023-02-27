using System;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                string result = "";
                char c = input[i];

                if(Char.IsUpper(c))
                {
                    result += Char.ToLower(c);
                }
                else if (Char.IsLower(c))
                {
                    result += Char.ToUpper(c);
                }
                else
                {
                    result += c;
                }

                Console.Write(result);
            }
        }
    }
}
