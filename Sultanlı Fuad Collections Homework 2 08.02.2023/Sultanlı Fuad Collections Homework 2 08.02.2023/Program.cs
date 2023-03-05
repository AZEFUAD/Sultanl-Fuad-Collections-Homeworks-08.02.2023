using System;
namespace Sultanlı_Fuad_Collections_Homework_2_08._02._2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            var student = new Student
            {
                Name = "Fuad",
                Surname = "Sultanlı",
                Pin = 4824
            };
            Checker(students, student);

            var student2 = new Student
            {
                Name = "Emin",
                Surname = "Iskenderov",
                Pin = 3298
            };
            Checker(students, student2);

            var student3 = new Student
            {
                Name = "Yalchin",
                Surname = "Reshidli",
                Pin = 9845
            };
            Checker(students, student3);

            foreach (var item in students)
            {
                Console.WriteLine(item.GetDetails());
            }

            StudentsWithA(students, student3);
        }

        public static void Checker(List<Student> students, Student student)
        {
            var isDublicatedId = students.Any(p => p.Pin == student.Pin);

            if (!isDublicatedId)
            {
                students.Add(student);
            }
        }

        public static void StudentsWithA(List<Student> classroom, Student student)
        {
            var count = classroom.Count(p => p.Name.Contains("a"));
            Console.WriteLine(count);
        }
    }
}
