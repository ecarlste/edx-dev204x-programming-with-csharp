
using System;
using System.Collections.Generic;

namespace ModuleFiveSixAssignment
{
    class Program
    {
        private static readonly string[] studentNames = { "Erik Carlsten", "Jordan Tate", "Phillip Morrison" };
        private const int newStudentCount = 3;
        private const int studentGradeCount = 5;

        static void Main(string[] args)
        {
            List<Student> students = CreateListOfStudentsWithGrades();

            Course course = CreateCourseAddStudentsAndTeacher("Programming with C#", students);
            Degree degree = CreateDegreeWithCourse("Bachelor of Science", course);
            UProgram program = CreateUProgramWithDegree("Information Technology", degree);

            PrintProgramInfo(program);
            PrintCourseStudentArrayListWithGrades(course);
        }

        private static List<Student> CreateListOfStudentsWithGrades()
        {
            List<Student> newStudents = new List<Student>();

            for (int i = 0; i < newStudentCount; i++)
            {
                string[] firstAndLastName = studentNames[i].Split(' ');

                Student student = new Student(firstAndLastName[0], firstAndLastName[1]);
                AddRandomGradesToStudent(student);
                newStudents.Add(student);
            }

            return newStudents;
        }

        private static void PrintCourseStudentArrayListWithGrades(Course course)
        {
            PrintTextSeparator("Students in ArrayList");

            foreach (object studentAsObject in course.StudentsEnrolled)
            {
                Student student = studentAsObject as Student;

                string studentFullName = student.FirstName + " " + student.LastName;
                int fullNameFieldWidth = (Console.WindowWidth / 2) + studentFullName.Length / 2;

                Console.WriteLine("{0, " + fullNameFieldWidth + "}", studentFullName);
            }
        }

        private static void PrintTextSeparator(string label)
        {
            string separatorLine = new String('-', Console.WindowWidth);
            string separatorBorder = "--";

            int labelFieldWidth = (Console.WindowWidth + label.Length) / 2 - separatorBorder.Length;
            int rightBorderFieldWidth = Console.WindowWidth - separatorBorder.Length - labelFieldWidth;
            
            Console.Write(Environment.NewLine + separatorLine);
            Console.Write("{1}{0," + labelFieldWidth + "}{1," + rightBorderFieldWidth + "}",
                label, separatorBorder);
            Console.WriteLine(separatorLine);
        }

        private static Course CreateCourseAddStudentsAndTeacher(string courseName, List<Student> studentsToAdd)
        {
            Course course = new Course(courseName);

            course.AddStudent(studentsToAdd);
            course.AddTeacher(new Teacher("John", "Paxton"));

            return course;
        }

        private static Degree CreateDegreeWithCourse(string degreeName, Course course)
        {
            Degree degree = new Degree(degreeName);
            degree.AddCourse(course);
            return degree;
        }

        private static UProgram CreateUProgramWithDegree(string programName, Degree degree)
        {
            UProgram program = new UProgram(programName);
            program.AddDegree(degree);
            return program;
        }

        private static void AddRandomGradesToStudent(Student student)
        {
            Random random = new Random();

            for (int i = 0; i < studentGradeCount; i++)
            {
                student.Grades.Push((float)random.NextDouble() * 100);
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
