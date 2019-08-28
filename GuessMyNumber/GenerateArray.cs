using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    class GenerateArray
    {
        public static void entryPoint()
        {
            int computerIteration = 0, humanIteration = 0;

            Console.WriteLine("How big of an array do you want?: ");
            int arraySize = int.Parse(Console.ReadLine());

            ComputerVsComputer.GuessNumber(createArray(arraySize), Program.selectValue(arraySize));

            Console.WriteLine("\n\nHow many games would you like to play?");
            int repetition = int.Parse(Console.ReadLine());

            for (int i = 0; i < repetition; i++)
            {
                humanIteration += ComputerVsHuman.GuessNumber(createArray(arraySize));
                computerIteration += HumanVsComputer.GuessUserNumber(createArray(arraySize));
            }

            Program.iterationDifference(humanIteration, computerIteration, repetition);
        }

        //input array elements starting from 1
        public static int[] createArray(int arraySize)
        {

            int[] array = new int[arraySize];

            for (int i = 1; i < arraySize + 1; i++)
            {
                array[i - 1] = i;
            }
            return array;
        }

        public static void printArray(int[] array)
        {
            Console.Write("int[] list = { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("}");
        }

    }
}
