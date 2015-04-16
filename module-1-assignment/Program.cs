using System;

namespace ModuleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region All Variables Declaration

            #region Student Variables Declaration

            String studentFirstName;
            String studentLastName;

            DateTime studentBirthdate;

            String studentAddressLine1;
            String studentAddressLine2;
            String studentCity;
            String studentStateProvince;            // complete name of state/province
            String studentZipPostal;                // string rather than int to handle international postal codes
            String studentCountry;

            Decimal studentAccountBalance;          /* positive values for credit in the students account, negative
                                                     * for owed. We are also going to assume USD $ for currency */
            float studentOverallGPA;
            char studentSex;                        // student sex can be 'M' or 'F'
            bool studentIsEnrolled;                 // is the student enrolled in a course?


            #endregion // Student Variables Declaration

            #region Professor Variables Declaration

            String professorFirstName;
            String professorLastName;

            DateTime professorBirthdate;

            String professorAddressLine1;
            String professorAddressLine2;
            String professorCity;
            String professorStateProvince;          // complete name of state/province
            String professorZipPostal;              // string rather than int to handle international postal codes
            String professorCountry;

            #endregion // Professor Variables Declaration

            #region University Degree Variables Declaration

            String degreeName;                      // i.e. "Bachelor of Science in Computer Science
            int degreeTotalCreditsRequired;         // total number of credits required to get the degree
            int degreeUpperLevelCreditsRequired;    // number of upper level credits required to get the degree

            #endregion // University Degree Variables Declaration

            #region University Program Variables Declaration

            String programName;
            String programDegreesOffered;           // i.e. "Bachelor, Master, Ph.D."
            string programDepartmentHead;           // full name of the department head

            #endregion // University Program Variables Declaration

            #endregion // All Variables Declaration

            // Assign values to the Students name and birthday variables and then print them as formatted output
            studentFirstName = "Erik";
            studentLastName = "Carlsten";
            studentBirthdate = new DateTime(1979, 4, 22);

            Console.WriteLine("{0} {1} was born on {2}", studentFirstName, studentLastName, studentBirthdate);

            // Assign values to the Student's address information and then print it as formatted output
            studentAddressLine1 = "2526 Landoe Street";
            studentAddressLine2 = "";   // no apartment number so left as an empty string
            studentCity = "Boulder";
            studentStateProvince = "Colorado";
            studentZipPostal = "75309-4512";
            studentCountry = "United States";

            Console.WriteLine("\nThey live at the following address:\n" +
                              "{0} {1}\n" +
                              "{2}, {3}\n" +
                              "{4}, {5}",
                              studentAddressLine1, studentAddressLine2, studentCity, studentStateProvince,
                              studentZipPostal, studentCountry);

            // Assign values to and print additional information about the student
            studentAccountBalance = -3425.42m;
            studentOverallGPA = 3.54f;
            studentSex = 'M';
            studentIsEnrolled = false;

            // we don't want to display true/false for the enrolled status, we want yes/no so lets make a variable we
            // can use for the output section. It would be ideal to just use a Unary operator in the Console.WriteLine
            // method call, but since we have not talked about those in class yet I will not be using one.
            String isEnrolledYesNo;
            if (studentIsEnrolled)
            {
                isEnrolledYesNo = "yes";
            }
            else
            {
                isEnrolledYesNo = "no";
            }

            // instead of using the \n to achieve a new line we use the Environment.NewLine string constant provided
            // by the .NET Framework just in case we happen to be running on a different Operating System that what we
            // are currently running for testing purposes.
            Console.WriteLine(Environment.NewLine + "More Information" + Environment.NewLine +
                              "--------------------------" + Environment.NewLine +
                              "Account Balance: ${0}" + Environment.NewLine +
                              "Overall GPA: {1}" + Environment.NewLine +
                              "Sex (M/F): {2}" + Environment.NewLine +
                              "Enrolled?: {3}",
                              studentAccountBalance, studentOverallGPA, studentSex, isEnrolledYesNo);

            // assign values to all of our professor variables and then output them in a formatted fashion
            professorFirstName = "John";
            professorLastName = "Paxton";
            professorBirthdate = new DateTime(1969, 5, 7);
            professorAddressLine1 = "1234 Amazing Lane";
            professorAddressLine2 = "Apt 42";
            professorCity = "HooliganVille";
            professorStateProvince = "Alberta";
            professorZipPostal = "K1A 0B1";
            professorCountry = "Canada";

            string NL = Environment.NewLine;    // rather than typing Environment.NewLine every time we want a new line
            // character lets save the string sequence in a variable for reuse

            Console.WriteLine("{0}{0}Professor {1} {2} was born on {3}", NL, professorFirstName, professorLastName,
                professorBirthdate);

            Console.WriteLine("{6}They live at the following address:{6}" +
                              "{0} {1}{6}" +
                              "{2}, {3}{6}" +
                              "{4}, {5}",
                              professorAddressLine1, professorAddressLine2, professorCity, professorStateProvince,
                              professorZipPostal, professorCountry, NL);

            // assign values to our degree and university program variables and output their values
            degreeName = "Bachelor of Science in Computer Science";
            degreeTotalCreditsRequired = 120;
            degreeUpperLevelCreditsRequired = 2 ^ 5;  // yes, you should know what this is immediately, if you don't then
            // look it up before you do anything else... or just run the
            // program and see what the output shows you!

            programName = "Computer Science";
            programDegreesOffered = "Bachelor, Master, Ph.D.";
            programDepartmentHead = "Mister Spock"; // Star Trek II: Planet Genesis Animation algorithm? A fun
            // SIGGRAPH paper to read in your spare time

            Console.WriteLine("{0}{0}The most in demand degree in the world is a {1}, which requires a total of {2}" +
                " credits to obtain. A total of {3} of those credits must be from upper level {4} courses. The" +
                " current {4} Department Head is {5}! The {4} department currently offers the following degree" +
                " plans: {6}", NL, degreeName, degreeTotalCreditsRequired, degreeUpperLevelCreditsRequired,
                programName, programDepartmentHead, programDegreesOffered);

        }
    }
}
