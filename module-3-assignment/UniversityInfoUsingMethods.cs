using System;

namespace ModuleThreeAssignment
{
    class UniversityInfoUsingMethods
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetCourseInfo();
            GetProgramInfo();
            GetDegreeInfo();

            TryValidatingBirthdateShowExceptionMessageOnFail();
        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();

            DateTime birthdate = GetStudentBirthdateAsStringAndConvertToDateTime();

            PrintStudentDetails(firstName, lastName, birthdate);
        }

        private static DateTime GetStudentBirthdateAsStringAndConvertToDateTime()
        {
            Console.WriteLine("Enter the student's birthdate (MM/DD/YYYY): ");
            string birthdateAsString = Console.ReadLine();

            return DateTime.Parse(birthdateAsString);
        }

        static void PrintStudentDetails(string firstName, string lastName, DateTime birthdate)
        {
            Console.WriteLine("{0}{1} {2} was born on: {3:MM/dd/yyyy}{0}",
                Environment.NewLine, firstName, lastName, birthdate);
        }

        private static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();

            DateTime birthdate = GetTeacherBirthdateAsStringAndConvertToDateTime();

            PrintTeacherDetails(firstName, lastName, birthdate);
        }

        private static DateTime GetTeacherBirthdateAsStringAndConvertToDateTime()
        {
            Console.WriteLine("Enter the teacher's birthdate (MM/DD/YYYY): ");
            string birthdateAsString = Console.ReadLine();

            return DateTime.Parse(birthdateAsString);
        }

        private static void PrintTeacherDetails(string firstName, string lastName, DateTime birthdate)
        {
            Console.WriteLine("{0}{1} {2} was born on: {3:MM/dd/yyyy}{0}",
                Environment.NewLine, firstName, lastName, birthdate);
        }

        private static void GetCourseInfo()
        {
            string courseName = GetCourseName();
            string courseNumber = GetCourseNumber();
            int courseCredits = GetCourseCreditsAsStringAndConvertToInt();

            PrintCourseDetails(courseName, courseNumber, courseCredits);
        }

        private static string GetCourseName()
        {
            Console.Write("Enter the course name: ");
            string courseName = Console.ReadLine();

            return courseName;
        }

        private static string GetCourseNumber()
        {
            Console.Write("Enter the course number (DEV204x): ");
            string courseName = Console.ReadLine();

            return courseName;
        }

        private static int GetCourseCreditsAsStringAndConvertToInt()
        {
            Console.Write("Enter the number of credits for the course: ");
            string courseCreditsAsString = Console.ReadLine();
            int courseNumber = Int32.Parse(courseCreditsAsString);

            return courseNumber;
        }

        private static void PrintCourseDetails(string courseName, string courseNumber, int courseCredits)
        {
            Console.WriteLine("{0}Course Name: {1}" + 
                              "{0}Course Number: {2}" + 
                              "{0}Course Credit Hours: {3}{0}",
                              Environment.NewLine, courseName, courseNumber, courseCredits);
        }

        private static void GetProgramInfo()
        {
            string programName = PromptUserForProgramName();
            string programDegreesAvailable = PromptUserForProgramDegreesAvailable();
            string programDepartmentHeadFullName = PromptUserForProgramDepartmentHeadFullName();

            PrintProgramDetails(programName, programDegreesAvailable, programDepartmentHeadFullName);
        }

        private static string PromptUserForProgramName()
        {
            Console.Write("Enter the program name: ");
            string programName = Console.ReadLine();

            return programName;
        }

        private static string PromptUserForProgramDegreesAvailable()
        {
            Console.Write("Enter the degrees available in the program (i.e., B.S.,M.S.,Ph.D.): ");
            string programDegreesAvailable = Console.ReadLine();

            return programDegreesAvailable;
        }

        private static string PromptUserForProgramDepartmentHeadFullName()
        {
            Console.Write("Enter the department head's full name: ");
            string departmentHeadFullName = Console.ReadLine();

            return departmentHeadFullName;
        }

        private static void PrintProgramDetails(string programName, string programDegreesAvailable,
            string programDepartmentHeadFullName)
        {
            Console.WriteLine("{0}Program Name: {1}" +
                              "{0}Degrees Available: {2}" +
                              "{0}Department Head: {3}{0}",
                              Environment.NewLine, programName, programDegreesAvailable,
                              programDepartmentHeadFullName);
        }

        private static void TryValidatingBirthdateShowExceptionMessageOnFail()
        {
            try
            {
                bool isBirthdateValid = IsStudentBirthdateValid(new DateTime(1979, 5, 21));
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}An exception was thrown when trying to validate the student's birthdate...{0}" +
                    "{1}", Environment.NewLine, e.Message);
            }
        }

        private static bool IsStudentBirthdateValid(DateTime studentBirthdateToValidate)
        {
            throw new NotImplementedException();
        }

        private static void GetDegreeInfo()
        {
        }
    }
}
