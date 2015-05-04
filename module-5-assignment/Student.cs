using System;
using System.Threading;

namespace ModuleFiveAssignment
{
    class Student
    {
        static int numberOfStudentsEnrolled = 0;
        public static int NumberOfStudentsEnrolled
        {
            get { return Student.numberOfStudentsEnrolled; }
        }

        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        DateTime birthdate;
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        string addressLine1;
        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        string addressLine2;
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        string stateOrProvince;
        public string StateOrProvince
        {
            get { return stateOrProvince; }
            set { stateOrProvince = value; }
        }

        string zipOrPostalCode;
        public string ZipOrPostalCode
        {
            get { return zipOrPostalCode; }
            set { zipOrPostalCode = value; }
        }

        string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        Decimal accountBalance;
        public Decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        float overallGPA;
        public float OverallGPA
        {
            get { return overallGPA; }
            set { overallGPA = value; }
        }

        char gender;
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        bool isEnrolled;
        public bool IsEnrolled
        {
            get { return isEnrolled; }
            set { isEnrolled = value; }
        }

        public Student(string firstName, string lastName, DateTime birthdate,
            string addressLine1, string addressLine2, string city,
            string stateOrProvince, string zipOrPostalCode, string country,
            Decimal accountBalance, float overallGPA, char gender,
            bool isEnrolled)
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

            Interlocked.Increment(ref numberOfStudentsEnrolled);
        }

        public Student() : this("", "", new DateTime(), "", "", "", "", "", "",
            0m, 0f, '\0', false)
        {}

        ~Student()
        {
            /* THIS IS NOT GOOD ENOUGH!!! Even though we have locked the thread
             * for both our constructor's increment and our destuctor's
             * decrement, we still don't know when the object will actually be
             * dealt with by the garbage collector. We would need to keep a
             * list of weak references to all the objects and when we check to
             * see how many there are, remove all the non-active weak
             * references to our Students created list. */

            Interlocked.Decrement(ref numberOfStudentsEnrolled);
        }
    }
}
