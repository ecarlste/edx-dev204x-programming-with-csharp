using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class UniversityInfoUsingClasses
    {
        static void Main(string[] args)
        {
            Course programmingWithCSharp = new Course("Programming with C#");
            
            programmingWithCSharp.AddStudent(
                new Student[]
                {
                    new Student(),
                    new Student(),
                    new Student()
                });

            programmingWithCSharp.AddTeacher(new Teacher());

            Degree bachelorOfScience = new Degree("Bachelor of Science");
        }
    }
}
