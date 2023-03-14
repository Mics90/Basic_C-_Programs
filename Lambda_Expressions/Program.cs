using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>()
           {
               new Employees{fName="Oliver",lName="Smith", ID=1},
               new Employees{fName="Noah",lName="Jones",ID=2},
               new Employees{fName="Joe",lName="Williams", ID=3},
               new Employees{fName="Olivia",lName="Taylor", ID=4},
               new Employees{fName="Joe",lName="Brown", ID=5},
               new Employees{fName="George",lName="Davies", ID=6},
               new Employees{fName="Arthur",lName="Evans", ID=7},
               new Employees{fName="Mia",lName="Jones", ID=8},
               new Employees{fName="Amelia",lName="Thomas", ID=9},
               new Employees{fName="Isla",lName="Evans", ID=10},


           };
            List<Employees> employee2 = new List<Employees>();
             int counter = 0;
            {
           
            foreach (Employees Employee in employee)
            {
                if (Employee.fName == "Joe")
                {
                        employee2.Add(Employee);
                        counter++;
                }

            }
        }
            Console.WriteLine("There are " + employee2.Count + " Joe's in our list");

           


            int employee3 =employee.Count(x => x.fName == "Joe");

            Console.WriteLine("There are " + employee3 + " Joe's in our list");


            int employee4 = employee.Count(x => x.ID > 5);

            Console.WriteLine("There are " + employee4 + " employees with ID higher that 5");
            Console.ReadLine();
        }

       


    }
    }

