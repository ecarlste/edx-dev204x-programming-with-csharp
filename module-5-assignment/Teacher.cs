
using System;

namespace ModuleFiveSixAssignment
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime birthdate,
            string addressLine1, string addressLine2, string city,
            string stateOrProvince, string zipOrPostalCode, string country)
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

        public Teacher() : this("", "", new DateTime(), "", "", "", "", "", "")
        {}

        public void GradeTest()
        {
            Console.WriteLine("{0} {1} just graded a test!", firstName, lastName);
        }
    }
}
