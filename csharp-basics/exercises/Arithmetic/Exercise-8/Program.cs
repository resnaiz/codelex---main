using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employee1, employee2, employee3;
            decimal salary1, salary2, salary3;
            int hoursWorked1, hoursWorked2, hoursWorked3;

            salary1 = 7.50m;
            salary2 = 8.20m;
            salary3 = 10.00m;
            
            hoursWorked1 = 35;
            hoursWorked2 = 47;
            hoursWorked3 = 73;

            Console.WriteLine($"Employee1 {CalculateSalary(salary1, hoursWorked1)}");
            Console.WriteLine($"Employee2 {CalculateSalary(salary2, hoursWorked2)}");
            Console.WriteLine($"Employee3 {CalculateSalary(salary3, hoursWorked3)}");
        }
        public static string CalculateSalary(decimal basicPay, int hoursWorked)
        {
            if(basicPay < 8.00m || hoursWorked > 60)
            {
                return "Error";
            }

            if(hoursWorked <= 40)
            {
                return (hoursWorked * basicPay).ToString();
            }

            var salary = 40 * basicPay;
            salary += (hoursWorked - 40) * (basicPay * 1.5m);
            return salary.ToString();
        }
    }
}
