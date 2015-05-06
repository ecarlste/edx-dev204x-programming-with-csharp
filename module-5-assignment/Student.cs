
using System;
using System.Collections.Generic;
using System.Threading;

namespace ModuleFiveSixAssignment
{
    class Student : Person
    {
        ////////////////////////
        // Grading Criteria 2 //
        ////////////////////////
        Stack<decimal> grades;
        public Stack<decimal> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        static int numberOfStudentsEnrolled = 0;
        public static int NumberOfStudentsEnrolled
        {
            get { return Student.numberOfStudentsEnrolled; }
        }

        Decimal accountBalance;
        public Decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        float overallGPA;
        public float OverallGPA
        {
            get { return overallGPA; }
            set { overallGPA = value; }
        }

        bool isEnrolled;
        public bool IsEnrolled
        {
            get { return isEnrolled; }
            set { isEnrolled = value; }
        }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            grades = new Stack<decimal>();
            Interlocked.Increment(ref numberOfStudentsEnrolled);
        }

        ~Student()
        {
            /* THIS IS NOT GOOD ENOUGH!!! Even though we have locked the thread
             * for both our constructor's increment and our destuctor's
             * decrement, we still don't know when the object will actually be
             * dealt with by the garbage collector. We would need to keep a
             * list of weak references to all the objects and when we check to
             * see how many there are, remove all the non-active weak
             * references to our Students created list. */

            Interlocked.Decrement(ref numberOfStudentsEnrolled);
        }

        public void TakeTest()
        {
            Console.WriteLine("{0} {1} just took a test!", firstName, lastName);
        }
    }
}
