namespace LearningNotes
{
    public abstract class Cat
    {
        private string color { get; set; }
        private string tipoPelo { get; set; }
        private string colorOjos { get; set; }

        public Cat(string color, string tipoPelo, string colorOjos)
        {
            this.color = color;
            this.tipoPelo = tipoPelo;
            this.colorOjos = colorOjos;
        }

        public abstract string Maullar();
        public abstract string Comer();
        public abstract string Dormir();
    }

    public class Siames : Cat
    {
        public Siames(string color, string tipoPelo, string colorOjos)
            : base(color, tipoPelo, colorOjos)
        {
        }

        public override string Maullar()
        {
            return "El gato siames maulla fuerte.";
        }

        public override string Comer()
        {
            return "El gato siames come pescado.";
        }

        public override string Dormir()
        {
            return "El gato siames duerme en lugares cálidos.";
        }
    }

    public class Persa : Cat
    {
        public Persa(string color, string tipoPelo, string colorOjos)
            : base(color, tipoPelo, colorOjos)
        {
        }

        public override string Maullar()
        {
            return "El gato persa maulla suavemente.";
        }

        public override string Comer()
        {
            return "El gato persa come comida seca.";
        }

        public override string Dormir()
        {
            return "El gato persa duerme mucho durante el día.";
        }
    }

    public class MaineCoon : Cat
    {
        public MaineCoon(string color, string tipoPelo, string colorOjos)
            : base(color, tipoPelo, colorOjos)
        {
        }

        public override string Maullar()
        {
            return "El gato Maine Coon maulla con un tono grave.";
        }

        public override string Comer()
        {
            return "El gato Maine Coon come carne.";
        }

        public override string Dormir()
        {
            return "El gato Maine Coon duerme en lugares altos.";
        }

    }

    public class Cats
    {
        public static void Demo()
        {
            Cat siames = new Siames("crema", "corto", "azul");
            Cat persa = new Persa("blanco", "largo", "verde");
            Cat maineCoon = new MaineCoon("marrón", "semilargo", "amarillo");

            Console.WriteLine(siames.Maullar());
            Console.WriteLine(persa.Comer());
            Console.WriteLine(maineCoon.Dormir());
        }
    }
}