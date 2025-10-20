# Notas de C# (separadas)

Este repositorio contiene todo el material y ejemplos que he ido desarrollando para aprender y reforzar mis conocimientos en C#, con el objetivo de utilizar el lenguaje en futuros proyectos y trabajar con diferentes herramientas del ecosistema .NET.
Cómo usar:

1. Desde `Program.cs` llama a los métodos estáticos, por ejemplo:

```csharp
using LearningNotes;

class Program
{
    static void Main(string[] args)
    {
        Utilities.MyMethod();
        ArraysAndLoops.PrintArrayExamples();
        StringsExamples.PrintStringExamples();
        TwoDArrayExamples.PrintTwoDArrayExamples();
        Console.WriteLine(Utilities.LinealSearch(new int[] {5,1,8,9}, 8));
    }
}
```

2. Compilar:

```
dotnet build
```
