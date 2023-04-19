using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person
    {
        private string EmpID;
        private double Salary;

        public Employee()
        {

        }

        public Employee(string fname, string lname, int age, string EmpID, double Salary) : base(fname, lname, age)
        {
            this.EmpID = EmpID;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEmp ID :" + EmpID
                + "\nSalary: " + Salary;
        }

        public override string DisplayInfo()
        {
            return base.ToString() + "\nEmp ID :" + EmpID
                + "\nSalary: " + Salary;
        }
    }
}
