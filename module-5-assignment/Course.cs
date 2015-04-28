using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Course
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string referenceNumber;
        public string ReferenceNumber
        {
            get { return referenceNumber; }
            set { referenceNumber = value; }
        }

        int creditHours;
        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }
        
        Student[] studentsEnrolled;
        internal Student[] StudentsEnrolled
        {
            get { return studentsEnrolled; }
            set { studentsEnrolled = value; }
        }

        Teacher[] TeachersAndAssistants;
        internal Teacher[] TeachersAndAssistants1
        {
            get { return TeachersAndAssistants; }
            set { TeachersAndAssistants = value; }
        }

        public Course(string name, string referenceNumber, int creditHours)
        {
            this.name = name;
            this.referenceNumber = referenceNumber;
            this.creditHours = creditHours;
        }
    }
}
