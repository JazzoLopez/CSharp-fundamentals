using System;

namespace LearningNotes
{
    public static class ArraysAndLoops
    {
        public static void PrintArrayExamples()
        {
            int[] numbers = new int[] { 5, 3, 8, 4, 2 };
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
