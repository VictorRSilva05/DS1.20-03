using ConsoleApp1.Entities;
namespace ConsoleApp1
{
    internal class Program
    {
        Program()
        {
            //Victor Rafael da Silva
            List<Person> people = new List<Person>();

            people.Add(new Student(111, "Victor", "Information systems"));
            people.Add(new Student(222, "Mateus", "Mechanical engineering"));
            people.Add(new Student(333, "Mariane", "Nursery"));

            people.Add(new Teacher(444, "Tio Lu", 9999));
            people.Add(new Teacher(555, "Patrick", 9999));

            people.Add(new Coordinator(666, "Gattino", 99999, "Information systems"));

            foreach (Person person in people)
            {
                if (person is Student s)
                {
                    Console.WriteLine($"Student Name: {s.Name} Id: {s.Id}");
                }
                else if (person is Teacher c)
                {
                    Console.WriteLine($"Teacher Name: {c.Name} Id: {c.Id}");
                }
                else if (person is Coordinator d)
                {
                    Console.WriteLine($"Coordinator Name: {d.Name} Id: {d.Id} Course: {d.Course}");
                }
            }
        }
        static void Main(string[] args)
        {
            _ = new Program();
        }
    }
}
