using System;

namespace ModuleFiveAssignment
{
    class Teacher
    {
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
    }
}
