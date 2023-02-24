using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "javascript", "python", "php", "oTHER" };
            string[] copyArray = Capitalize(newArray);
            Console.WriteLine("Capitalized array - " + string.Join(", ", copyArray));
        }

        static string[] Capitalize(string[] array)
        {
            string[] namesCap = new string[array.Length];
            
            for(int i = 0; i < array.Length; i++)
            {
                string name = array[i].ToLower();
                namesCap[i] = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            }

            return namesCap;
        }
    }
}
