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
            string userPromptMessage = "Enter the student's first name: ";
            string firstName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the student's last name: ";
            string lastName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the student's birthdate (MM/DD/YYYY): ";
            DateTime birthdate = PromptUserForDateTimeInput(userPromptMessage);

            PrintStudentDetails(firstName, lastName, birthdate);
        }

        static void PrintStudentDetails(string firstName, string lastName, DateTime birthdate)
        {
            Console.WriteLine("{0}{1} {2} was born on: {3:MM/dd/yyyy}{0}",
                Environment.NewLine, firstName, lastName, birthdate);
        }

        private static void GetTeacherInfo()
        {
            string userPromptMessage = "Enter the teacher's first name: ";
            string firstName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the teacher's last name: ";
            string lastName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the teacher's birthdate (MM/DD/YYYY): ";
            DateTime birthdate = PromptUserForDateTimeInput(userPromptMessage);

            PrintTeacherDetails(firstName, lastName, birthdate);
        }

        private static void PrintTeacherDetails(string firstName, string lastName, DateTime birthdate)
        {
            Console.WriteLine("{0}{1} {2} was born on: {3:MM/dd/yyyy}{0}",
                Environment.NewLine, firstName, lastName, birthdate);
        }

        private static void GetCourseInfo()
        {
            string userPromptMessage = "Enter the course name: ";
            string courseName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the course number (i.e., DEV204x): ";
            string courseNumber = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the number of credits for the course: ";
            int courseCredits = PromptUserForInt32Input(userPromptMessage);

            PrintCourseDetails(courseName, courseNumber, courseCredits);
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
            string userPromptMessage = "Enter the program name: ";
            string programName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the degrees available in the program (i.e., B.S.,M.S.,Ph.D.): ";
            string programDegreesAvailable = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the department head's full name: ";
            string programDepartmentHeadFullName = PromptUserForStringInput(userPromptMessage);

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
            string userPromptMessage = "Enter degree name: ";
            string degreeName = PromptUserForStringInput(userPromptMessage);

            userPromptMessage = "Enter the total number of credit hours to complete the degree: ";
            int degreeTotalCreditsRequiredToComplete = PromptUserForInt32Input(userPromptMessage);

            userPromptMessage = "Enter the number of upper level credit hours to complete the degree: ";
            int degreeUpperLevelCreditsRequiredToComplete = PromptUserForInt32Input(userPromptMessage);

            PrintDegreeDetails(degreeName, degreeTotalCreditsRequiredToComplete,
                degreeUpperLevelCreditsRequiredToComplete);
        }

        private static void PrintDegreeDetails(string degreeName, int degreeTotalCreditsRequiredToComplete,
            int degreeUpperLevelCreditsRequiredToComplete)
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

        private static string PromptUserForStringInput(string userPromptMessage)
        {
            Console.Write(userPromptMessage);
            string userResponseToPrompt = Console.ReadLine();

            return userResponseToPrompt;
        }

        private static DateTime PromptUserForDateTimeInput(string userPromptMessage)
        {
            Console.Write(userPromptMessage);
            string userResponseToPrompt = Console.ReadLine();
            DateTime userResponseAsDateTime = DateTime.Parse(userResponseToPrompt);

            return userResponseAsDateTime;
        }

        private static int PromptUserForInt32Input(string userPromptMessage)
        {
            Console.Write(userPromptMessage);
            string userResponseToPrompt = Console.ReadLine();
            int userResponseAsInt32 = Int32.Parse(userResponseToPrompt);

            return userResponseAsInt32;
        }

        private static bool IsStudentBirthdateValid(DateTime studentBirthdateToValidate)
        {
            throw new NotImplementedException();
        }
    }
}
