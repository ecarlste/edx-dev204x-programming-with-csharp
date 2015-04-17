using System;

namespace ModuleFourAssignment
{
    class UniversityInfoUsingStructs
    {
        struct Student
        {
            internal string firstName;
            internal string lastName;

            internal DateTime birthdate;

            internal string addressLine1;
            internal string addressLine2;
            internal string city;
            internal string stateOrProvince;
            internal string zipOrPostalCode;
            internal string country;

            internal Decimal accountBalance;
            internal float overallGPA;
            internal char gender;
            internal bool isEnrolled;

            public Student(string firstName, string lastName, DateTime birthdate, string addressLine1,
                string addressLine2, string city, string stateOrProvince, string zipOrPostalCode, string country,
                Decimal accountBalance, float overallGPA, char gender, bool isEnrolled)
            {
                this.firstName = firstName;
                this.lastName = lastName;

                this.birthdate = birthdate;

                this.addressLine1 = addressLine1;
                this.addressLine2 = addressLine2;
                this.city = city;
                this.stateOrProvince = stateOrProvince;
                this.zipOrPostalCode = zipOrPostalCode;
                this.country = country;

                this.accountBalance = accountBalance;
                this.overallGPA = overallGPA;
                this.gender = gender;
                this.isEnrolled = isEnrolled;
            }
        }

        struct Professor
        {
            internal string firstName;
            internal string lastName;

            internal DateTime birthdate;

            internal string addressLine1;
            internal string addressLine2;
            internal string city;
            internal string stateOrProvince;
            internal string zipOrPostalCode;
            internal string country;

            public Professor(string firstName, string lastName, DateTime birthdate, string addressLine1,
                string addressLine2, string city, string stateOrProvince, string zipOrPostalCode, string country)
            {
                this.firstName = firstName;
                this.lastName = lastName;

                this.birthdate = birthdate;

                this.addressLine1 = addressLine1;
                this.addressLine2 = addressLine2;
                this.city = city;
                this.stateOrProvince = stateOrProvince;
                this.zipOrPostalCode = zipOrPostalCode;
                this.country = country;
            }
        }

        struct AcademicProgram
        {
            [Flags]
            internal enum AcademicDegrees
            {
                BachelorOfScience = 0x01,
                MasterOfScience = 0x02,
                DoctorOfPhilosophy = 0x04,

                AllAvailableDegrees = BachelorOfScience & MasterOfScience & DoctorOfPhilosophy,
            }

            internal string name;
            internal AcademicDegrees degreesOffered;
            internal string departmentHeadFullName;

            public AcademicProgram(string name, AcademicDegrees degreesOffered, string departmentHeadFullName)
            {
                this.name = name;
                this.degreesOffered = degreesOffered;
                this.departmentHeadFullName = departmentHeadFullName;
            }
        }

        struct AcademicCourse
        {
            internal string name;
            internal string referenceNumber;
            internal int creditHours;

            public AcademicCourse(string name, string referenceNumber, int creditHours)
            {
                this.name = name;
                this.referenceNumber = referenceNumber;
                this.creditHours = creditHours;
            }
        }

        static void Main(string[] args)
        {
            Student[] students = CreateStudentArrayAndPopulateOneEntry();

            OutputValuesOfStudentStruct(students[0]);
        }

        private static Student[] CreateStudentArrayAndPopulateOneEntry()
        {
            Student[] students = new Student[5];

            students[0] = new Student
                (
                    "Fred", "Flintstone", new DateTime(1941, 7, 3), "417 Special Bvd", "", "Boulder", "Montana",
                    "55542", "US", 217.31m, 3.29f, 'M', false
                );

            return students;
        }

        private static void OutputValuesOfStudentStruct(Student student)
        {
            Console.WriteLine(
                "First Name: {0}{1}" +
                "Last Name: {2}{1}" +
                "Birthdate: {3:MM/dd/yyyy}{1}{1}" +
                
                "Address{1}" +
                "-------{1}" +
                "{4} {5}{1}" +
                "{6}, {7}{1}" +
                "{8}, {9}{1}{1}" +

                "Account Balance: {10}{1}" +
                "Overall GPA: {11}{1}" +
                "Gender: {12}{1}" +
                "Student Currently Enrolled?: {13}",

                student.firstName, Environment.NewLine, student.lastName, student.birthdate, student.addressLine1,
                student.addressLine2, student.city, student.stateOrProvince, student.zipOrPostalCode, student.country,
                student.accountBalance, student.overallGPA, student.gender, student.isEnrolled
                );
        }
    }
}
