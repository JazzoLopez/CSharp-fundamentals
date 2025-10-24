using System.Collections;

namespace LearningNotes
{
    public static class Collections
    {
        public static void ShowCollections()
        {
            var orden = new List<string> { "Primero", "Segundo", "Tercero" };

            foreach (var item in orden)
            {
                Console.WriteLine(item);
            }

            orden.Add("Cuarto");
            orden.Remove("Segundo");

            ArrayList arrayList = new ArrayList { 1, "Dos", 3.0 };

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, Elemento> elementos = new Dictionary<string, Elemento>
            {
            {"H", new Elemento("H","Hidrógeno",1) },
            {"He", new Elemento("He","Helio",2) },
            {"Li", new Elemento("Li","Litio",3) },
            {"Be", new Elemento("Be","Berilio",4) },
            {"B", new Elemento("B","Boro",5) },
            {"C", new Elemento("C","Carbono",6) },
            {"N", new Elemento("N","Nitrógeno",7) },
            {"O", new Elemento("O","Oxígeno",8) },
            {"F", new Elemento("F","Flúor",9) },
            {"Ne", new Elemento("Ne","Neón",10) }
            };

            foreach (KeyValuePair<string, Elemento> kvp in elementos)
            {
                Elemento elemento = kvp.Value;
                Console.WriteLine("Símbolo: {0}, Nombre: {1}, Número Atómico: {2}", elemento.simbolo, elemento.nombre, elemento.numeroAtomico);
            }
        }


    }

    public class Elemento
    {
        public string simbolo;
        public string nombre;
        public int numeroAtomico;

        public Elemento(string simbolo, string nombre, int numeroAtomico)
        {
            this.simbolo = simbolo;
            this.nombre = nombre;
            this.numeroAtomico = numeroAtomico;
        }


    }
}