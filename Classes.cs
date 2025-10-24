namespace LearningNotes
{
    public static class Classes
    {
        public class Person
        {
            private string name { get; set; } // SOLO ACCEDEN A TRAVÉS DE MÉTODOS
            private string age { get; set; }
            private string gender { get; set; }

            public Person(string name, string age, string gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
            }

            public string getData()
            {
                return $"Name: {name}, Age: {age},  Gender  : {gender}";
            }
        }

        public class Student : Person
        {
            private string studentId { get; set; }

            public Student(string name, string age, string gender, string studentId)
                : base(name, age, gender)
            {
                this.studentId = studentId;
            }

            public string getStudentData()
            {
                return $"{getData()}, Student ID: {studentId}";
            }

        }

        public struct SPerson
        {
            public string Name;
            public int Age;

            public SPerson(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        //Clases estaticas 

        public static class DemoClasses
        {
            public static void ShowMessage()
            {
                Console.WriteLine("This is a static class method.");
            }
        }
        public static void Demo()
        {
            Person person = new Person("Alice", "30", "Female");
            Student student = new Student("Bob", "20", "Male", "S12345");
            Console.WriteLine(person.getData());
            Console.WriteLine(student.getStudentData());
            //llamado a clases estaticas
            DemoClasses.ShowMessage();
        }

        public class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The dog barks.");
            }
        }

        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The cat meows.");
            }
        }

        public class A
        {
            public virtual void Saludo()
            {
                Console.WriteLine("Hola desde la clase A");
            }
        }

        public class B : A
        {
            public sealed override void Saludo()
            {
                Console.WriteLine("Hola desde la clase B");
            }
        }

        public class C : B
        {
            public new void Saludo()
            {
                Console.WriteLine("Hola desde la clase C");
                base.Saludo();
            }
        }

        //explicacion de las clases ABC y lo que hace:
        // Clase A: Define un método virtual Saludo() que puede ser sobrescrito por clases derivadas.
        // Clase B: Hereda de A y sobrescribe el método Saludo(). Además, utiliza la palabra clave sealed para evitar que futuras clases derivadas puedan sobrescribir este método.
        // Clase C: Hereda de B e intenta sobrescribir el método Saludo(). Sin embargo, debido a que B selló el método, C no puede sobrescribirlo. En su lugar, C define un nuevo método Saludo() utilizando la palabra clave new, que oculta el método de la clase base B. Dentro de este nuevo método, C llama al método Saludo() de B utilizando base.Saludo().
    }

    //CLASES ABSTRACTAS
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }

}


