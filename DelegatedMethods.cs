namespace LearningNotes
{
    public static class DelegatedMethods
    {
        static void demo()
        {
            Del manejador = Ejemplo;
            manejador("Hola desde el delegado");
            Ejemplo2(10, 20, manejador);
            
        }


        public static void Ejemplo(string message)
        {
            Console.WriteLine(message);
        }

        static void Ejemplo2(int param1, int param2, Del llamada)
        {
            llamada($"Los parámetros son: {param1} y {param2}");
        }

        public delegate void Del(string message);
    }
}

