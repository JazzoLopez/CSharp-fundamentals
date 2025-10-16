using LearningNotes;

class Program
{
    static void Main(string[] args)
    {
        Utilities.MyMethod();
        ArraysAndLoops.PrintArrayExamples();
        StringsExamples.PrintStringExamples();
        TwoDArrayExamples.PrintTwoDArrayExamples();
        Console.WriteLine(Utilities.LinealSearch(new int[] { 5, 1, 8, 9 }, 8));
        MultipleInterfaces.ShowMultipleInterfaces();
        Operators.Demo();
        StringCharacters.PrintCharacters();
        Structures.GetStructuresExample();

    }
}