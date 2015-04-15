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
            string firstName = PromptUserForStringInput("Enter the student's first name: ");
            string lastName = PromptUserForStringInput("Enter the student's last name: ");

            DateTime birthdate = GetStudentBirthdateAsStringAndConvertToDateTime();

            PrintStudentDetails(firstName, lastName, birthdate);
        }

        private static string PromptUserForStringInput(string userPromptMessage)
        {
            Console.Write(userPromptMessage);
            string userResponseToPrompt = Console.ReadLine();

            return userResponseToPrompt;
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
            string firstName = PromptUserForStringInput("Enter the teacher's first name: ");
            string lastName = PromptUserForStringInput("Enter the teacher's last name: ");
            
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
            string courseName = PromptUserForStringInput("Enter the course name: ");
            string courseNumber = PromptUserForStringInput("Enter the course number (i.e., DEV204x): ");
            int courseCredits = GetCourseCreditsAsStringAndConvertToInt();

            PrintCourseDetails(courseName, courseNumber, courseCredits);
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
            Console.WriteLine(
                "{0}Course Name: {1}" +
                "{0}Course Number: {2}" +
                "{0}Course Credit Hours: {3}{0}",
                Environment.NewLine, courseName, courseNumber, courseCredits
            );
        }

        private static void GetProgramInfo()
        {
            string programName = PromptUserForStringInput("Enter the program name: ");
            string programDegreesAvailable = PromptUserForStringInput(
                "Enter the degrees available in the program (i.e., B.S.,M.S.,Ph.D.): ");
            string programDepartmentHeadFullName = PromptUserForStringInput("Enter the department head's full name: ");

            PrintProgramDetails(programName, programDegreesAvailable, programDepartmentHeadFullName);
        }

        private static void PrintProgramDetails(string programName, string programDegreesAvailable,
            string programDepartmentHeadFullName)
        {
            Console.WriteLine(
                "{0}Program Name: {1}" +
                "{0}Degrees Available: {2}" +
                "{0}Department Head: {3}{0}",
                Environment.NewLine, programName, programDegreesAvailable, programDepartmentHeadFullName
            );
        }

        private static void GetDegreeInfo()
        {
            string degreeName = PromptUserForStringInput("Enter degree name: ");
            int degreeTotalCreditsRequiredToComplete = PromptUserForTotalCreditsRequiredToCompleteConvertToInt32();
            int degreeUpperLevelCreditsRequiredToComplete =
                PromptUserForUpperLevelCreditsRequiredToCompleteConvertToInt32();

            PrintDegreeDetails(degreeName, degreeTotalCreditsRequiredToComplete,
                degreeUpperLevelCreditsRequiredToComplete);
        }

        private static int PromptUserForTotalCreditsRequiredToCompleteConvertToInt32()
        {
            Console.Write("Enter the total number of credit hours to complete the degree: ");
            string totalNumberOfCreditsToCompleteAsString = Console.ReadLine();
            int totalNumberOfCreditsToComplete = Int32.Parse(totalNumberOfCreditsToCompleteAsString);

            return totalNumberOfCreditsToComplete;
        }

        private static int PromptUserForUpperLevelCreditsRequiredToCompleteConvertToInt32()
        {
            Console.Write("Enter the number of upper level credit hours to complete the degree: ");
            string numberOfUpperLevelCreditsToCompleteAsString = Console.ReadLine();
            int numberOfUpperLevelCreditsToComplete = Int32.Parse(numberOfUpperLevelCreditsToCompleteAsString);

            return numberOfUpperLevelCreditsToComplete;
        }

        private static void PrintDegreeDetails(string degreeName, int degreeTotalCreditsRequiredToComplete, int degreeUpperLevelCreditsRequiredToComplete)
        {
            Console.WriteLine(
                "{0}Degree Name: {1}" +
                "{0}Total Credit Hours: {2}" +
                "{0}Upper Level Credits Hours: {3}{0}",
                Environment.NewLine, degreeName, degreeTotalCreditsRequiredToComplete,
                degreeUpperLevelCreditsRequiredToComplete
            );
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
    }
}
