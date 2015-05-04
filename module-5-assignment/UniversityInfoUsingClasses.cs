using System;

namespace ModuleFiveAssignment
{
    class UniversityInfoUsingClasses
    {
        static void Main(string[] args)
        {
            Course programmingWithCSharp = new Course("Programming with C#");
            programmingWithCSharp.AddStudent(
                new Student[]
                {
                    new Student(),
                    new Student(),
                    new Student()
                });
            programmingWithCSharp.AddTeacher(new Teacher());

            Degree bachelorOfScience = new Degree("Bachelor of Science");
            bachelorOfScience.AddCourse(programmingWithCSharp);

            UProgram informationTechnologyProgram = new UProgram(
                "Information Technology");
            informationTechnologyProgram.AddDegree(bachelorOfScience);

            PrintProgramInfo(informationTechnologyProgram);
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
