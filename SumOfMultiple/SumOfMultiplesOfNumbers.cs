using System;

namespace SumOfMultiple
{
    public class SumOfMultiplesOfNumbers
    {
        /// <summary>
        /// Finds summation of multiples of given 2 numbers below an upper limit
        /// </summary>
        /// <param name="upperLimit">Upper limit for the calculation</param>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>The sum</returns>
        public static int FindSumOfMultiplesOfNumbers(int upperLimit, int number1, int number2)
        {
            int generalSum = 0;

            // Proceed only if arguments are not null and upperLimit is non-negative, avoid throwing exceptions for flow control and return -1 on tricky situations instead
            if (upperLimit > 0)
            {

                if (upperLimit >= number1 && number1 > 0)
                {
                    generalSum += SumOfMultiplesOf(number1, upperLimit);
                }
                else
                {
                    Console.WriteLine("ERR: Invalid arguments: number1");
                    return -1;
                }

                if (upperLimit >= number2 && number2 > 0)
                {
                    generalSum += SumOfMultiplesOf(number2, upperLimit);
                }
                else
                {
                    Console.WriteLine("ERR: Invalid arguments: number2");
                    return -1;
                }

                // Remove the sums we've counted in twice
                generalSum -= SumOfMultiplesOf(number1 * number2, upperLimit);

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
