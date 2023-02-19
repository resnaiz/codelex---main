using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = GetMenu();

            while (choice != 4)
            {
                switch (choice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                }
                choice = GetMenu();
            }

            Console.WriteLine("Exiting program...");
        }

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            int userChoice = int.Parse(Console.ReadLine());
            var keyboard = Console.ReadKey();
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine(" - Invalid choice. Please enter a number from 1 to 4.");
                Console.Write("Enter your choice (1-4): ");
                userChoice = int.Parse(Console.ReadLine());
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            
            Console.WriteLine("What is the circle's radius? ");
            //todo
            string input = Console.ReadLine();
            double radius = Convert.ToDouble(input);
            decimal decimalRad = Convert.ToDecimal(radius);


            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(decimalRad));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            length = Convert.ToDecimal(Console.ReadLine());
            //todo

            // Get width
            Console.WriteLine("Enter width? ");
            width = Convert.ToDecimal(Console.ReadLine());
            //todo

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            //todo
            //read key value
            ground = Convert.ToDecimal(Console.ReadLine());
            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            //read key value
            height= Convert.ToDecimal(Console.ReadLine());
            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
