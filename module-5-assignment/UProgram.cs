using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        Degree[] degreesOffered;
        internal Degree[] DegreesOffered
        {
            get { return degreesOffered; }
            set { degreesOffered = value; }
        }

        string departmentHeadFullName;
        public string DepartmentHeadFullName
        {
            get { return departmentHeadFullName; }
            set { departmentHeadFullName = value; }
        }

        public UProgram(string name, Degree[] degreesOffered,
            string departmentHeadFullName)
        {
            this.name = name;
            this.degreesOffered = degreesOffered;
            this.departmentHeadFullName = departmentHeadFullName;
        }
    }
}
