using System;

namespace Mod2_SelfAssess
{
    class Program
    {
        static void Main(string[] args)
        {
            var program1 = new UProgram() { Name = "Information Technology" };

            var students = new[]
            {
                new Student("Delia", "Mandle"),
                new Student("Martin", "Smith", DateTime.Parse("13-01-2000")){ Address = "2 Clockhouse Road\nTriptree", Postcode = "TT3 5RT"},
                new Student("Monica", "Stuhl", DateTime.Parse("21-07-1999"))
            };

            var course1 = new Course() { Name = "Programming with C#" };

            course1.students = students;

            var aTeacher = new Teacher("Ena", "McQuinn", DateTime.Parse("1967-01-13"));

            course1.teachers = new Teacher[1] { aTeacher };

            var degree1 = new Degree() { Name = "Bachelor" };

            degree1.course = course1;

            program1.degree = degree1;

            Console.WriteLine($"Program: {program1.Name}\nDegree: {program1.degree.Name}");
            Console.WriteLine($"Course: {program1.degree.course.Name}");
            Console.WriteLine($"Number of students: {program1.degree.course.students[0].getStudentCount()}");

            Console.WriteLine("\nTeachers\n");
            foreach (var tutor in program1.degree.course.teachers)
            {
                Console.WriteLine(tutor.ToString());
            }

            Console.WriteLine("\nStudents\n");

            foreach (var pupil in program1.degree.course.students)
            {
                Console.WriteLine($"{pupil.ToString()}\n");
            }
        }
    }
}
