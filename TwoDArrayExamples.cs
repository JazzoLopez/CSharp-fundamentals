using System;

namespace LearningNotes
{
    public static class TwoDArrayExamples
    {
        public static void PrintTwoDArrayExamples()
        {
            int[,] numbersbidimensionales = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbersbidimensionales.GetLength(0); i++)
            {
                for (int j = 0; j < numbersbidimensionales.GetLength(1); j++)
                {
                    Console.WriteLine(numbersbidimensionales[i, j]);
                }
            }
        }
    }
}
