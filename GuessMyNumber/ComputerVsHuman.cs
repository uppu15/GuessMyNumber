using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuessMyNumber
{
    class ComputerVsHuman
    {
        //computer set a random number, human make guess
        public static int GuessNumber(int[] array)
        {
            Console.WriteLine("\nComputer will pick a number, you make guess");
            int iterationCount = 0, inputValue = 0, newArray = 0;
            double maxIteration = Math.Log(array.Length, 2);

            int computerRandom = Program.selectValue(array.Length);
            while (array != null && iterationCount < maxIteration)
            {

                GenerateArray.printArray(array);
                inputValue = int.Parse(Console.ReadLine());
                if (inputValue == computerRandom)
                {
                    iterationCount++;
                    Console.WriteLine("The value searched for, {0}, has been found", computerRandom);
                    break;
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (inputValue == array[i])
                        {
                            newArray = i;
                        }
                    }
                    if (inputValue < computerRandom)
                    {
                        Console.WriteLine($"value is higher than {inputValue}");
                        array = array.Skip(newArray + 1).ToArray();
                        iterationCount++;
                    }
                    else if (inputValue > computerRandom)
                    {
                        Console.WriteLine($"value is lower than {inputValue}");
                        array = array.Take(newArray).ToArray();
                        iterationCount++;
                    }
                }
                if (iterationCount > maxIteration)
                {
                    Console.WriteLine("You ran out of chance");
                }
            }


            return iterationCount;
        }
    }
}
