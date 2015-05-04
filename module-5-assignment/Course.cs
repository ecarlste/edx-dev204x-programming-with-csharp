
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
        
        Student[] studentsEnrolled;
        public Student[] StudentsEnrolled
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

            studentsEnrolled = new Student[3];
            teachersAndAssistants = new Teacher[3];
        }

        public Course(string name) : this(name, "", 0)
        {}

        public void AddStudent(Student[] studentsToAdd)
        {
            foreach (Student student in studentsToAdd)
            {
                AddStudent(student);
            }
        }

        public void AddStudent(Student student)
        {
            int studentCount = studentsEnrolled.Count(s => s != null);
            studentsEnrolled[studentCount] = student;
        }

        public void AddTeacher(Teacher teacher)
        {
            int teacherCount = teachersAndAssistants.Count(s => s != null);
            teachersAndAssistants[teacherCount] = teacher;
        }
    }
}
