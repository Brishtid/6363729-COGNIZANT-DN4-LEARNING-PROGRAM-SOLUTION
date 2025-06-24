using System;
using System.Collections.Generic;

namespace ForecastApp
{
    class ForecastCalculator
    {
        
        private static Dictionary<int, double> cache = new Dictionary<int, double>();

        
        public static double GetForecast(double amount, double growthRate, int period)
        {
            if (period == 0)
                return amount;

            if (cache.ContainsKey(period))
                return cache[period];

            double updatedAmount = amount * (1 + growthRate);
            double forecast = GetForecast(updatedAmount, growthRate, period - 1);

            cache[period] = forecast;
            return forecast;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Financial Forecast Calculator : ");

            Console.Write("Initial investment amount: ");
            double initialAmount = double.Parse(Console.ReadLine());

            Console.Write("Annual increase rate (like 0.07 for 7%): ");
            double growth = double.Parse(Console.ReadLine());

            Console.Write("Number of years to forecast: ");
            int duration = int.Parse(Console.ReadLine());

            double predictedAmount = ForecastCalculator.GetForecast(initialAmount, growth, duration);
            Console.WriteLine($"\nPredicted Value After {duration} Years: {predictedAmount:F2}");

            Console.WriteLine("\nAnalysis:");
            Console.WriteLine("Recursive time complexity without caching: O(n)");
            Console.WriteLine("Optimized with caching (memoization): nearly O(1) for repeated periods");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}