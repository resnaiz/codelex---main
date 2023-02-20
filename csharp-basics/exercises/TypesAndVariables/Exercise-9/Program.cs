using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Input distance in meters:");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input hours:");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input minutes:");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input seconds:");
        int seconds = Convert.ToInt32(Console.ReadLine());

        int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
        double metersPerSecond = distance / totalSeconds;
        double kilometersPerHour = (distance / 1000.0) / (totalSeconds / 3600.0);
        double milesPerHour = (distance / 1609.0) / (totalSeconds / 3600.0);

        Console.WriteLine("Your speed in meters/second is: " + metersPerSecond.ToString("F8"));
        Console.WriteLine("Your speed in km/h is: " + kilometersPerHour.ToString("F8"));
        Console.WriteLine("Your speed in miles/h is: " + milesPerHour.ToString("F8"));
    }
}

