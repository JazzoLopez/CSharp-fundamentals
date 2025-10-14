interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some other text...");
    }
}

public static class MultipleInterfaces
{
    public static void ShowMultipleInterfaces()
    {
        DemoClass obj = new DemoClass();
        obj.myMethod();
        obj.myOtherMethod();
    }
}