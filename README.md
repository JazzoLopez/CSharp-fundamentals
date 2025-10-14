# Notas de C# (separadas)

Archivos creados para organizar las notas de estudio en temas:

- `Utilities.cs` — Métodos utilitarios (MyMethod, LinealSearch, funciones de ejemplo).
- `ArraysAndLoops.cs` — Ejemplos de arrays, ordenamiento y bucles.
- `StringsExamples.cs` — Ejemplos de manejo de strings y substrings.
- `TwoDArrayExamples.cs` — Ejemplos con arrays bidimensionales.

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
