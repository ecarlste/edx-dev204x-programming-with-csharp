
using System;
using System.Collections.Generic;

namespace ModuleFiveSixAssignment
{
    class Program
    {
        private const int newStudentCount = 3;
        private const int studentGradeCount = 5;

        static void Main(string[] args)
        {
            List<Student> students = CreateListOfStudentsWithGrades();

            Course programmingWithCSharp =
                CreateCourseAddStudentsAndTeacher("Programming with C#", students);

            Degree bachelorOfScience = new Degree("Bachelor of Science");
            bachelorOfScience.AddCourse(programmingWithCSharp);

            UProgram informationTechnologyProgram = new UProgram(
                "Information Technology");
            informationTechnologyProgram.AddDegree(bachelorOfScience);

            PrintProgramInfo(informationTechnologyProgram);
        }

        private static List<Student> CreateListOfStudentsWithGrades()
        {
            List<Student> newStudents = new List<Student>();

            for (int i = 0; i < newStudentCount; i++)
            {
                Student student = new Student();
                AddRandomGradesToStudent(student);
                newStudents.Add(student);
            }

                return newStudents;
        }

        private static Course CreateCourseAddStudentsAndTeacher(string courseName, List<Student> studentsToAdd)
        {
            Course course = new Course(courseName);

            course.AddStudent(studentsToAdd);
            course.AddTeacher(new Teacher());

            return course;
        }

        private static void AddRandomGradesToStudent(Student student)
        {
            Random random = new Random();

            for (int i = 0; i < studentGradeCount; i++)
            {
                student.Grades.Push((float)random.NextDouble());
            }
        }

        private static void PrintProgramInfo(UProgram program)
        {
            Console.WriteLine("The {0} program contains the {1} degree{2}",
                program.Name, program.DegreesOffered[0].Name,
                Environment.NewLine);

            Console.WriteLine("The {0} degree contains the course {1}{2}",
                program.DegreesOffered[0].Name,
                program.DegreesOffered[0].RequiredCourses[0].Name,
                Environment.NewLine);
            
            Console.WriteLine("The {0} course contains {1} student(s)",
                program.DegreesOffered[0].RequiredCourses[0].Name,
                Student.NumberOfStudentsEnrolled, Environment.NewLine);
        }
    }
}
