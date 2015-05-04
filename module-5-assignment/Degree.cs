using System.Collections.Generic;

namespace ModuleFiveAssignment
{
    class Degree
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int totalCreditsRequired;
        public int TotalCreditsRequired
        {
            get { return totalCreditsRequired; }
            set { totalCreditsRequired = value; }
        }

        int upperLevelCreditsRequired;
        public int UpperLevelCreditsRequired
        {
            get { return upperLevelCreditsRequired; }
            set { upperLevelCreditsRequired = value; }
        }

        List<Course> requiredCourses;
        public List<Course> RequiredCourses
        {
            get { return requiredCourses; }
        }

        public Degree(string name) : this(name, 0, 0)
        {}

        public Degree(string name, int totalCreditsRequired,
            int upperLevelCreditsRequired)
        {
            this.name = name;
            this.totalCreditsRequired = totalCreditsRequired;
            this.upperLevelCreditsRequired = upperLevelCreditsRequired;

            this.requiredCourses = new List<Course>();
        }

        public void AddCourse(Course courseToAdd)
        {
            requiredCourses.Add(courseToAdd);
        }
    }
}
