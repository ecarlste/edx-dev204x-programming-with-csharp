using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
