using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuessMyNumber
{
    class HumanVsComputer
    {
        //User pick a number, then computer will show steps to guess that number
        //Made this method to guess the number using Random
        public static int GuessUserNumber(int[] array)
        {
            Console.WriteLine($"\n\nYou pick a number, computer will guess.\nPick a random number between {array[0]} - {array[array.Length - 1]}");
            int inputValue = int.Parse(Console.ReadLine());
            Random r = new Random();

            int iterationCount = 0, newArray = 0, computerRandom;
            double maxIteration = Math.Log(array.Length, 2);
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

                computerRandom = r.Next(array[0], array[array.Length - 1]);

                if (inputValue == computerRandom)
                {
                    iterationCount++;
                    Console.WriteLine("The value searched for, {0}, has been found", inputValue);
                    break;
                }
                else
                {
                    Console.WriteLine($"System choose {computerRandom}");
                    Console.Write($"Was your number higher or lower than {computerRandom}? up ? down?: ");
                    string direction = Console.ReadLine();

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (computerRandom == array[i])
                        {
                            newArray = i;
                        }
                    }

                    if (direction == "up")
                    {
                        Console.WriteLine($"value is higher than {computerRandom}");
                        array = array.Skip(newArray + 1).ToArray();
                        iterationCount++;
                    }
                    else if (direction == "down")
                    {
                        Console.WriteLine($"value is lower than {computerRandom}");
                        array = array.Take(newArray).ToArray();
                        iterationCount++;
                    }
                }
                if (iterationCount > maxIteration)
                {
                    Console.WriteLine("System ran out of chance");
                }
            }

            return iterationCount;
        }
    }
}
