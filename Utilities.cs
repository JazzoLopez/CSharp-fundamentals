using System;

namespace LearningNotes
{
    public static class Utilities
    {
        public static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        public static int LinealSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Funcion()
        {
            return 1;
        }

        public static double Funcion(double x)
        {
            return x;
        }
    }
}
