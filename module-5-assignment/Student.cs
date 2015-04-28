﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Student
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
        }
    }
}
