
using System;

namespace ModuleFiveSixAssignment
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {}

        public void GradeTest()
        {
            Console.WriteLine("{0} {1} just graded a test!", firstName, lastName);
        }
    }
}
