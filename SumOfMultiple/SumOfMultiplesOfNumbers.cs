using System;

namespace SumOfMultiple
{
    public class SumOfMultiplesOfNumbers
    {
        public static int FindSumOfMultiplesOfNumbers(int upperLimit, params int[] listOfNumbers)
        {
            int generalSum = 0;

            // Proceed only if arguments are not null and upperLimit is non-negative, avoid throwing exceptions for flow control and return -1 on tricky situations instead
            if (listOfNumbers?.Length > 0 && upperLimit > 0)
            {
                for (int i = 0; i < listOfNumbers.Length; i++)
                {
                    int currentNumber = listOfNumbers[i];

                    if (upperLimit >= currentNumber && currentNumber > 0)
                    {
                        generalSum += SumOfMultiplesOf(currentNumber, upperLimit);
                    }

                    else
                    {
                        Console.WriteLine("ERR: Invalid arguments");
                        return -1;
                    }
                }

                return generalSum;
            }
            else
            {
                Console.WriteLine("ERR: Invalid arguments");
                return -1;
            }

        }

        // The sum of numbers divisible by any number below a limit is essentially:
        // Number * (1 + 2 + ... + (limit - 1) / number)
        // So we can apply the Gauss formula here for the right side of multiplication to get Number * ((Limit - 1) / number) * (((Limit - 1) / number) + 1) / 2)
        private static int SumOfMultiplesOf(int number, int upperLimit)
        {
            return number * ((upperLimit - 1) / number) * (((upperLimit - 1) / number) + 1) / 2;
            
        }
    }
}
