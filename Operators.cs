using System;

namespace LearningNotes
{
    public static class Operators
    {
        public static void Demo()
        {
            Console.WriteLine("--- Operadores de asignación ---");
            int a = 10;        // asignación simple
            int b = a;         // copia de valor
            b += 5;            // operador compuesto (b = b + 5)
            b -= 2;            // b = b - 2
            b *= 2;            // b = b * 2
            b /= 3;            // b = b / 3 (división entera)
            b %= 3;            // resto de la división
            Console.WriteLine($"a={a}, b={b}");

            Console.WriteLine("\n--- Operadores aritméticos ---");
            int x = 7, y = 3;
            Console.WriteLine($"x + y = {x + y}");
            Console.WriteLine($"x - y = {x - y}");
            Console.WriteLine($"x * y = {x * y}");
            Console.WriteLine($"x / y = {x / y}  (división entera)");
            Console.WriteLine($"(double)x / y = {(double)x / y}  (división en punto flotante)");
            Console.WriteLine($"x % y = {x % y} (módulo)");
            Console.WriteLine($"x++ = {x++} (post-incremento), ahora x={x}");
            Console.WriteLine($"++y = {++y} (pre-incremento), ahora y={y}");

            Console.WriteLine("\n--- Operadores relacionales ---");
            Console.WriteLine($"x == y -> {x == y}");
            Console.WriteLine($"x != y -> {x != y}");
            Console.WriteLine($"x > y  -> {x > y}");
            Console.WriteLine($"x < y  -> {x < y}");
            Console.WriteLine($"x >= y -> {x >= y}");
            Console.WriteLine($"x <= y -> {x <= y}");

            Console.WriteLine("\n--- Operadores lógicos ---");
            bool p = true, q = false;
            Console.WriteLine($"p && q -> {p && q} (AND lógico)");
            Console.WriteLine($"p || q -> {p || q} (OR lógico)");
            Console.WriteLine($"!p -> {!p} (NOT lógico)");
            // diferencia entre & y && (&& evalúa cortocircuito)
            Console.WriteLine($"true & false -> {true & false} (AND sin cortocircuito)");
            Console.WriteLine($"true | false -> {true | false} (OR sin cortocircuito)");

            Console.WriteLine("\n--- Operadores bit a bit ---");
            int m = 6;  // 0110
            int n = 3;  // 0011
            Console.WriteLine($"m & n = {m & n} (AND bit a bit)");
            Console.WriteLine($"m | n = {m | n} (OR bit a bit)");
            Console.WriteLine($"m ^ n = {m ^ n} (XOR bit a bit)");
            Console.WriteLine($"~m = {~m} (NOT bit a bit)");
            Console.WriteLine($"m << 1 = {m << 1} (shift left)");
            Console.WriteLine($"m >> 1 = {m >> 1} (shift right)");

            Console.WriteLine("\n--- Operador ternario y null-coalescing ---");
            int value = 5;
            string resultado = value % 2 == 0 ? "par" : "impar"; // ternario
            Console.WriteLine($"{value} es {resultado}");

            string? maybe = null;
            string text = maybe ?? "valor por defecto"; // null-coalescing
            Console.WriteLine($"maybe ?? -> {text}");

            Console.WriteLine("\n--- Operadores de asignación con desplazamiento y bitwise ---");
            int s = 1;
            s <<= 2; // s = s << 2
            Console.WriteLine($"s after <<=2 -> {s}");

            Console.WriteLine("\n--- checked / unchecked ---");
            // checked lanza OverflowException si se produce overflow en tipos integrales
            try
            {
                checked
                {
                    int max = int.MaxValue;
                    Console.WriteLine($"int.MaxValue = {max}");
                    // causa overflow
                    int overflowed = max + 1;
                    Console.WriteLine(overflowed); // esto no se ejecutará si se lanza excepción
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow detectado en checked (int.MaxValue + 1)");
            }

            // unchecked permite overflow silencioso (comportamiento por defecto en algunas compilaciones)
            unchecked
            {
                int max = int.MaxValue;
                int wrapped = max + 1; // se envuelve sin excepción
                Console.WriteLine($"unchecked int.MaxValue + 1 -> {wrapped}");
            }

            Console.WriteLine("\n--- Otros operadores útiles ---");
            int? nullable = null;
            Console.WriteLine($"nullable.HasValue -> {nullable.HasValue}");
            // operador de propagación nula (?.) y el operador de asignación condicional (??=)
            string? maybeName = null;
            maybeName ??= "Sin nombre"; // asigna sólo si es null
            Console.WriteLine($"maybeName -> {maybeName}");

            Console.WriteLine("\n--- Recomendaciones y notas ---");
            Console.WriteLine("- Usa operadores compuestos (+=, -=) para concisión y claridad.");
            Console.WriteLine("- Usa checked cuando necesites detectar overflow en cálculos críticos.");
            Console.WriteLine("- Ten en cuenta la diferencia entre && (cortocircuito) y & (sin cortocircuito).\n");
        }
    }
}
