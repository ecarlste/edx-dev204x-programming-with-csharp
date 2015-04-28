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
        private string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string lastName;
        private string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        DateTime birthdate;
        private DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        string addressLine1;
        private string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        string addressLine2;
        private string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        string city;
        private string City
        {
            get { return city; }
            set { city = value; }
        }

        string stateOrProvince;
        private string StateOrProvince
        {
            get { return stateOrProvince; }
            set { stateOrProvince = value; }
        }

        string zipOrPostalCode;
        private string ZipOrPostalCode
        {
            get { return zipOrPostalCode; }
            set { zipOrPostalCode = value; }
        }

        string country;
        private string Country
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
