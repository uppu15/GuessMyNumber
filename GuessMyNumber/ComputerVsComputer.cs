using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuessMyNumber
{
    class ComputerVsComputer
    {
        //computer plays game by itself
        public static void GuessNumber(int[] array, int inputValue)
        {
            int iterationCount = 0;
            string output = string.Empty;
            double maxIteration = Math.Log(array.Length, 2), median = 0;
            Console.WriteLine($">> int value = {inputValue}");

            while (array != null && iterationCount <= maxIteration)
            {
                Console.WriteLine("\n>> bisection_search(value, list)");
                GenerateArray.printArray(array);
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                median = (double)sum / array.Length;

                if (inputValue == (int)median)
                {
                    iterationCount++;
                    Console.WriteLine("The value searched for, {0}, has been found", inputValue);
                    break;
                }
                else
                {
                    if (inputValue > median)
                    {
                        Console.WriteLine($"value is higher than {(int)median}");
                        array = array.Skip((array.Length / 2)).ToArray();
                        iterationCount++;
                    }
                    else if (inputValue < median)
                    {
                        Console.WriteLine($"value is lower than {(int)median}");
                        array = array.Take(array.Length / 2).ToArray();
                        iterationCount++;
                    }

                    if (median % 1.0 == 0)
                    {
                        Console.WriteLine($"The middle value is {median}");
                    }
                    else if (median % 1.0 != 0)
                    {
                        Console.WriteLine($"The middle value is {median}, but we are doing integer division");
                    }
                }
            }
        }

    }
}
