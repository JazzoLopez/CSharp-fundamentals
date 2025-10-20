namespace LearningNotes
{
    public static class Fibonacci
    {
        public static int GetFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int ant = 0, sig = 1, temp;
            for (int i = 2; i <= n; i++)
            {
                temp = sig;
                sig = ant + sig;
                ant = temp;
            }
            return sig;
        }

        public static int GetFibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
        }
    }
}
