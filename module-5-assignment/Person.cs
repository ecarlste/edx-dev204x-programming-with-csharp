
using System;

namespace ModuleFiveSixAssignment
{
    class Person
    {
        protected string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        protected string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        protected DateTime birthdate;
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        protected string addressLine1;
        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        protected string addressLine2;
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        protected string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        protected string stateOrProvince;
        public string StateOrProvince
        {
            get { return stateOrProvince; }
            set { stateOrProvince = value; }
        }

        protected string zipOrPostalCode;
        public string ZipOrPostalCode
        {
            get { return zipOrPostalCode; }
            set { zipOrPostalCode = value; }
        }

        protected string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        protected Gender gender;
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }

    enum Gender
    {
        NotSpecified,
        Female,
        Male,
        Other
    }
}
