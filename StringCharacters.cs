namespace LearningNotes
{
    public static class StringCharacters
    {
        public static void PrintCharacters()
        {
            string example = "Hola";
            Console.WriteLine($"La cadena es: {example}");
            Console.WriteLine("Caracteres individuales:");
            for (int i = 0; i < example.Length; i++)
            {
                Console.WriteLine($"Índice {i}: '{example[i]}' (código Unicode: {(int)example[i]})");
            }

            //SENTENCIAS DE ESCAPE

            string withEscapes = "Línea1\nLínea2\tTabulado\nComilla simple: \'\nComilla doble: \"\nBarra invertida: \\ \n Valor no asignado :\0 \n Alerta: \a \n retroceso \b \n Retorno de carro: \r \n Nueva línea: \n \n Formato vertical: \v \n Avance de página: \f";
            Console.WriteLine("\nCadena con secuencias de escape:");
            Console.WriteLine(withEscapes);
        }
    }
}