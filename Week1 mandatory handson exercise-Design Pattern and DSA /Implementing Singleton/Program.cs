using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Singleton Pattern:\n");
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message.");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message.");

        if (logger1 == logger2)
        {
            Console.WriteLine("\nBoth logger1 and logger2 refer to the same instance.");
        }
        else
        {
            Console.WriteLine("\nDifferent Logger instances detected! Singleton failed.");
        }
    }
}
