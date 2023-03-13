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

            Employee employee = new Employee();
            employee.ID = 2;
            employee.fName = "Dan";
            employee.lName = "Gruu";

            Employee employee2 = new Employee();
            employee2.ID = 1;
            employee2.fName = "Maria";
            employee2.lName = "Dinero";
            if (Equals(employee.ID, employee2.ID))
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
        
  

