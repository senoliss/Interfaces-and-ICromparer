namespace Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Tomas",
                    Year = 2001,
                },
                new Student
                {
                    Id = 2,
                    Name = "Marius",
                    Year = 1999,
                },
                new Student
                {
                    Id = 3,
                    Name = "Deivis",
                    Year = 1985,
                }
            };

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            students.Sort(new StudentComparerById());

            //students.OrderBy(x=>x.Id);

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}