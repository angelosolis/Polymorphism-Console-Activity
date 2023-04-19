using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Student : Person
    {
        private string StudentID;
        private string Course;

        public Student()
        {

        }

        public Student(string fname, string lname, int age, string StudentID, string Course) : base(fname, lname, age)
        {
            this.StudentID = StudentID;
            this.Course = Course;
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudentID :" + StudentID
                + "\nCourse: " + Course;
        }

        public override string DisplayInfo()
        {
            return base.ToString() + "\nStudentID :" + StudentID
                 + "\nCourse: " + Course;
        }
    }
}
