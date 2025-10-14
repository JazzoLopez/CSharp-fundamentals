using System;

namespace LearningNotes
{
    public static class StringsExamples
    {
        public static void PrintStringExamples()
        {
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}
