namespace LearningNotes
{
    public static class Classes
    {
        public class Person
        {
            private string name { get; set; }
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

        public static void Demo()
        {
            Person person = new Person("Alice", "30", "Female");
            Student student = new Student("Bob", "20", "Male", "S12345");
            Console.WriteLine(person.getData());
            Console.WriteLine(student.getStudentData());
        }
    }

}


