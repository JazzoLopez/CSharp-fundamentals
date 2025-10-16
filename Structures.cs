namespace LearningNotes
{
    public static class Structures
    {
        public static void GetStructuresExample()
        {
            Direccion casa;
            casa.numero = 123;
            casa.calle = "Calle Falsa";
            casa.ciudad = "Springfield";
            Console.WriteLine(casa.getDireccion());

        }
        struct Direccion
        {
            public int numero;
            public string calle;
            public string ciudad;

            public string getDireccion()
            {
                return $"{calle} {numero}, {ciudad}";
            }
        }
    }
}