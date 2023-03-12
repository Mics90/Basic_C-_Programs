using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {



            var Employee = new Employee(); 

            Employee.FirstName = "Student";
            Employee.LastName = "Sample";
            Employee.SayName();

            {
                Console.ReadLine();
            }
        }
    }
}
