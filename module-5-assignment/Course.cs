
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ModuleFiveSixAssignment
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
        
        ArrayList studentsEnrolled;
        public ArrayList StudentsEnrolled
        {
            get { return studentsEnrolled; }
        }

        Teacher[] teachersAndAssistants;
        public Teacher[] TeachersAndAssistants
        {
            get { return teachersAndAssistants; }
        }

        public Course() : this("", "", 0)
        {}

        public Course(string name, string referenceNumber, int creditHours)
        {
            this.name = name;
            this.referenceNumber = referenceNumber;
            this.creditHours = creditHours;

            studentsEnrolled = new ArrayList();
            teachersAndAssistants = new Teacher[3];
        }

        public Course(string name) : this(name, "", 0)
        {}

        public void AddStudent(Student student)
        {
            studentsEnrolled.Add(student);
        }
        
        public void AddStudent(Student[] studentsToAdd)
        {
            foreach (Student student in studentsToAdd)
            {
                AddStudent(student);
            }
        }

        public void AddStudent(List<Student> studentsToAdd)
        {
            AddStudent(studentsToAdd.ToArray());
        }

        public void AddTeacher(Teacher teacher)
        {
            int teacherCount = teachersAndAssistants.Count(s => s != null);
            teachersAndAssistants[teacherCount] = teacher;
        }
    }
}
