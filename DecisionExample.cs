namespace DecisionSentences
{
    public static class DecisionSentences
    {
        public static void PrintDecisionExamples()
        {
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
            //nullish
            string? isExist = null;
            string message = isExist ?? "is not exist";
            Console.WriteLine(message);

            int hour = 10;
            if (hour < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            if (day == 4)
            {
                goto salida;
            }

        salida:
            Console.WriteLine("This is the end of the program.");
        }
    }
}