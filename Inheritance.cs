namespace LearningNotes
{
    public class Inheritance
    {
        public static void Demo()
        {
            Chihuahua perro = new("Soy un perro de raza Chihuahua");
            Console.WriteLine(perro.Ladrar());
        }

        public class Perro
        {
            private string v;

            public Perro(string v)
            {
                this.v = v;
            }

            public string Ladrar()
            {
                return "Guau";
            }
        }

        public class Chihuahua : Perro
        {
            public void ladraChihuahua()
            {
                base.Ladrar();
            }
            public Chihuahua(string y) : base("Soy un perro de raza Chihuahua")
            {
                Console.WriteLine(y);
            }
        }
    }
}