using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from array");

            GenerateArray.entryPoint();
        }

        //as last portion of direction state, compare who finds number quicker
        public static void iterationDifference(int humanIteration, int computerIteration, int repetition)
        {
            Console.WriteLine($"\n\nFor {repetition} games, you gave {humanIteration} attempts, averages out to {(double)humanIteration/repetition} attempts per game.");
            Console.WriteLine($"computer gave {computerIteration} attempts, averages out to {(double)computerIteration/repetition} attempts per game.");

            if (humanIteration > computerIteration)
            {
                Console.WriteLine("Computer won.\n\n");
            }
            else
            {
                Console.WriteLine("You won.\n\n");
            }
        }

        public static int selectValue(int arraySize)
        {
            Random r = new Random();

            return r.Next(1, arraySize);
        }


    }
}
