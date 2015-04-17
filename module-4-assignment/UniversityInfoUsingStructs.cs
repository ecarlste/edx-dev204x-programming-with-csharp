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

        struct Teacher 
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

            public Teacher(string firstName, string lastName, DateTime birthdate, string addressLine1,
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

        static void Main(string[] args)
        {
            Student[] students = CreateStudentArrayAndPopulateOneEntry();

            Console.WriteLine(students[0].firstName);
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
    }
}
