using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee { firstName = "Sample", lastName = "Student" };
            Employee.SayName();


            Employee SampleEmployee = new Employee() { firstName = "Sample", lastName = "Student" };//
            SampleEmployee.Quit();
            Console.ReadLine();

        }
    }
}
