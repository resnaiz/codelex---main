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
            int choice;
            do
            {
                choice = GetMenu();
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
                    case 4:
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);
        }
        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            return userChoice;
        }
        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            decimal area = (decimal)Geometry.AreaOfCircle(radius);
            Console.WriteLine("The circle's area is " + area);
        }
        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("Enter length? ");
            length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter width? ");
            width = decimal.Parse(Console.ReadLine());
            decimal area = (decimal)Geometry.AreaOfRectangle(length, width);
            Console.WriteLine("The rectangle's area is " + area);
        }
        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");
            ground = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter triangle's height? ");
            height = decimal.Parse(Console.ReadLine());
            decimal area = (decimal)Geometry.AreaOfTriangle(ground, height);
            Console.WriteLine("The triangle's area is " + area);
        }
    }
}