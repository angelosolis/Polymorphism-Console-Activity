using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Person
    {
        private string fname;
        private string lname;
        private int age;

        public Person()
            {
            }
        
        public Person(string fname, string lname, int age)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }

        public override string ToString()
        {
            return "First Name: " + fname
                + "\nLast Name: " + lname
                + "\nAge: " + age;
        }

        public abstract string DisplayInfo();
    }
}
