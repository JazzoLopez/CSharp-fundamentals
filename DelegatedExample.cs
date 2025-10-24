using System.Collections;

namespace LearningNotes
{
    class DelegatedExample
    {
        static void demo()
        {
            LibroDB libroDB = new LibroDB();
            addLibros(libroDB);

            System.Console.WriteLine("Imprimiendo títulos de libros con portada de papel:");
            libroDB.ProcesarLibros(imprimirTitulo);

            Total total = new Total();
            libroDB.ProcesarLibros(total.PrecioTotal);
            System.Console.WriteLine("Precio total de libros con portada de papel: " + total.MontoTotal);
        }

        static void imprimirTitulo(Libro libro)
        {
            System.Console.WriteLine("Título: " + libro.Titulo);
        }

        static void addLibros(LibroDB libroDB)
        {
            libroDB.AgregarLibro("Cien Años de Soledad", "Gabriel García Márquez", 20, true);
            libroDB.AgregarLibro("1984", "George Orwell", 15, false);
            libroDB.AgregarLibro("Don Quijote de la Mancha", "Miguel de Cervantes", 25, true);
            libroDB.AgregarLibro("El Principito", "Antoine de Saint-Exupéry", 10, true);
        }
        public class Libro
        {
            public string Titulo;
            public string Autor;
            public int Precio;
            public bool PortadaPapel;

            public Libro(string titulo, string autor, int precio, bool portadaPapel)
            {
                this.Titulo = titulo;
                this.Autor = autor;
                this.Precio = precio;
                this.PortadaPapel = portadaPapel;
            }
        }

        public delegate void ProcesarLibro(Libro libro);

        public class LibroDB
        {
            ArrayList libros = new ArrayList();

            public void AgregarLibro(string titulo, string autor, int precio, bool portadaPapel)
            {
                libros.Add(new Libro(titulo, autor, precio, portadaPapel));
            }

            public void ProcesarLibros(ProcesarLibro procesar)
            {
                foreach (Libro libro in libros)
                {
                    if (libro.PortadaPapel)
                    {
                        procesar(libro);
                    }
                }
            }
        }

        public class Total
        {
            public decimal MontoTotal = 0;
            public void PrecioTotal(Libro libro)
            {
                MontoTotal += libro.Precio;
            }
        }
    }
}