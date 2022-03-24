using System;
using SequenceAnalysis;
using SumOfMultiple;
namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nWelcome to the Runner application!\n");
                Console.WriteLine("Please select which operation you'd like to do by typing the relative number:");
                Console.WriteLine("1. Summation Of Multiple Numbers");
                Console.WriteLine("2. Sequence Analysis");

                string input = Console.ReadLine();
                int resultInt = 0;
                string resultString = String.Empty;
                switch (input)
                {
                    case "1":
                        Console.WriteLine("This operation will find the sum of multiples of 3 and 5 below a given limit.");
                        Console.WriteLine("Please enter an upper limit:");
                        input = Console.ReadLine();
                        resultInt = SumOfMultiplesOfNumbers.FindSumOfMultiplesOfNumbers(int.Parse(input), 3, 5);
                        Console.WriteLine("Result is: " + resultInt);
                        break;
                    case "2":
                        Console.WriteLine("This operation will find and sort uppercase words in a given string.");
                        Console.WriteLine("Please enter a string:");
                        input = Console.ReadLine();
                        resultString = StringSequenceAnalysis.RunAnalysis(input);
                        Console.WriteLine("Result is: " + resultString);
                        break;
                    default:
                        Console.WriteLine("Unrecognized input, please try again!");
                        break;
                }

                Console.WriteLine("Thanks for using the Runner, type Q to exit or anything else for a new operation");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    isRunning = false;
                }
            }
        }
    }
}
