using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class UProgram
    {
        [Flags]
        public enum AcademicDegrees
        {
            BachelorOfScience = 0x01,
            MasterOfScience = 0x02,
            DoctorOfPhilosophy = 0x04,

            AllAvailableDegrees = BachelorOfScience & MasterOfScience & DoctorOfPhilosophy,
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        AcademicDegrees degreesOffered;
        internal AcademicDegrees DegreesOffered
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

        public UProgram(string name, AcademicDegrees degreesOffered,
            string departmentHeadFullName)
        {
            this.name = name;
            this.degreesOffered = degreesOffered;
            this.departmentHeadFullName = departmentHeadFullName;
        }
    }
}
