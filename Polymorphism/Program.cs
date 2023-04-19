using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pr;
            Console.WriteLine("Student");     
            pr = new Student("Angelo", "Solis", 20, "19097393", "Information Technology");
            Console.WriteLine(pr.DisplayInfo());

            Console.WriteLine();
            Console.WriteLine("Employee");
            pr = new Employee("Solis", "Ängelo", 20, "20202020", 10000.00);
            Console.WriteLine(pr.DisplayInfo());
        }
    }
}
