using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { fName = "Dan", lName = "Gruu", ID = 1 };
            Employee emloyee2 = new Employee() { fName = "Maria", lName = "Dinero", ID = 2 };

            var EmployeeID = employee.ID == emloyee2.ID;

            if(EmployeeID == true)
            {
                Console.WriteLine("Employee ID are equal!");
            }
            else
            {
                Console.WriteLine("Employee ID are not equal!");
            }
            Console.ReadLine();
        }
    }
}
