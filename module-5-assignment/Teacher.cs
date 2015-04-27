using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Teacher
    {
        private string firstName;
        internal string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        internal string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private DateTime birthdate;
        internal DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        private string addressLine1;
        internal string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        private string addressLine2;
        internal string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        private string city;
        internal string City
        {
            get { return city; }
            set { city = value; }
        }

        private string stateOrProvince;
        internal string StateOrProvince
        {
            get { return stateOrProvince; }
            set { stateOrProvince = value; }
        }

        private string zipOrPostalCode;
        internal string ZipOrPostalCode
        {
            get { return zipOrPostalCode; }
            set { zipOrPostalCode = value; }
        }

        private string country;
        internal string Country
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
    }
}
