using System;

namespace ModuleThreeAssignment
{
    class UniversityInfoUsingMethods
    {
        static void Main(string[] args)
        {
            //GetStudentInfo();
            //GetTeacherInfo();
            GetCourseInfo();
            GetProgramInfo();
            GetDegreeInfo();

            TryValidatingBirthdateOrShowExceptionMessage();
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

        private static void TryValidatingBirthdateOrShowExceptionMessage()
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

        private static void GetProgramInfo()
        {
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
            throw new NotImplementedException();
        }

        private static string GetCourseNumber()
        {
            throw new NotImplementedException();
        }

        private static int GetCourseCreditsAsStringAndConvertToInt()
        {
            throw new NotImplementedException();
        }

        private static void PrintCourseDetails(string courseName, string courseNumber, int courseCredits)
        {
            throw new NotImplementedException();
        }
    }
}
