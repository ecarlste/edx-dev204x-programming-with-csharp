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
        }

        static void Main(string[] args)
        {
        }
    }
}
