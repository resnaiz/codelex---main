using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string class1 = "English III";
            string class2 = "Precalculus";
            string class3 = "Music Theory";
            string class4 = "Biotechnology";
            string class5 = "Principles of Technology I";
            string class6 = "Latin II";
            string class7 = "AP US History";
            string class8 = "Business Computer Information Systems";

            string teacher1 = "Ms. Lapan";
            string teacher2 = "Mrs. Gideon";
            string teacher3 = "Mr. Davis";
            string teacher4 = "Ms. Palmer";
            string teacher5 = "Ms. Garcia";
            string teacher6 = "Mrs. Barnett";
            string teacher7 = "Ms. Johannessen";
            string teacher8 = "Mr. James";

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| 1 | {0,-26} | {1,-15} |", class1, teacher1);
            Console.WriteLine("| 2 | {0,-26} | {1,-15} |", class2, teacher2);
            Console.WriteLine("| 3 | {0,-26} | {1,-15} |", class3, teacher3);
            Console.WriteLine("| 4 | {0,-26} | {1,-15} |", class4, teacher4);
            Console.WriteLine("| 5 | {0,-26} | {1,-15} |", class5, teacher5);
            Console.WriteLine("| 6 | {0,-26} | {1,-15} |", class6, teacher6);
            Console.WriteLine("| 7 | {0,-26} | {1,-15} |", class7, teacher7);
            Console.WriteLine("| 8 | {0,-26} | {1,-15} |", class8, teacher8);
            Console.WriteLine("+------------------------------------------------------------+");
        }
    }
}
