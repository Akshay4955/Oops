namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oops Problems Project");

            // create person and make it hello
            Person person = new Person();
            person.Greet();

            // create student, set age and display greet and age
            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();

            // Create Teacher, set age and say hello & explain
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}