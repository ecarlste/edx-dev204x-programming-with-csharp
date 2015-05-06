using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
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

        string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}
