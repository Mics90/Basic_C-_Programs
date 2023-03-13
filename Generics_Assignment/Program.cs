using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeName = new Employee<string>();
            Employee<int> employeeID = new Employee<int>();
            employeeName.Things = new List<string>();
            employeeName.Things.Add("Nauris");
            employeeName.Things.Add("Ita");
            employeeName.Things.Add("Victor");
           

            employeeID.Things = new List<int>();
            employeeID.Things.Add(1);
            employeeID.Things.Add(2);
            employeeID.Things.Add(3);
            

            for (int i = 0; i < employeeName.Things.Count; i++)
            {
                Console.WriteLine("Employee Name :{0} ", employeeName.Things[i]);

            }
            for (int i = 0; i < employeeID.Things.Count; i++)
            {
                Console.WriteLine(" Employee ID :{0} ", employeeID.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
