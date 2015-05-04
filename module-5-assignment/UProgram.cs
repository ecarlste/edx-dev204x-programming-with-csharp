using System.Collections.Generic;

namespace ModuleFiveAssignment
{
    class UProgram
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        List<Degree> degreesOffered;
        public List<Degree> DegreesOffered
        {
            get { return degreesOffered; }
        }

        string departmentHeadFullName;
        public string DepartmentHeadFullName
        {
            get { return departmentHeadFullName; }
            set { departmentHeadFullName = value; }
        }

        public UProgram(string name, List<Degree> degreesOffered,
            string departmentHeadFullName)
        {
            this.name = name;
            this.degreesOffered = degreesOffered;
            this.departmentHeadFullName = departmentHeadFullName;
        }

        public UProgram(string name) : this(name, new List<Degree>(), "")
        {}

        public void AddDegree(Degree degree)
        {
            degreesOffered.Add(degree);
        }
    }
}
