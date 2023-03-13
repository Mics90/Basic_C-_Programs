using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Employee
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }



        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID.Equals(employee2.ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.ID.Equals(employee2.ID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override bool Equals(object obj)
        {
            Employee employee = obj as Employee;
            if (employee != null)
            {
                return employee.ID.Equals(ID);
            }
            else
            {
                return false;
            }
        }
       
    }
}